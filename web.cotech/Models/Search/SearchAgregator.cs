﻿#region Copyright (c) 2000-2020 Developer Express Inc.
/*
{*******************************************************************}
{                                                                   }
{       Developer Express .NET Component Library                    }
{                                                                   }
{                                                                   }
{       Copyright (c) 2000-2020 Developer Express Inc.              }
{       ALL RIGHTS RESERVED                                         }
{                                                                   }
{   The entire contents of this file is protected by U.S. and       }
{   International Copyright Laws. Unauthorized reproduction,        }
{   reverse-engineering, and distribution of all or any portion of  }
{   the code contained in this file is strictly prohibited and may  }
{   result in severe civil and criminal penalties and will be       }
{   prosecuted to the maximum extent possible under the law.        }
{                                                                   }
{   RESTRICTIONS                                                    }
{                                                                   }
{   THIS SOURCE CODE AND ALL RESULTING INTERMEDIATE FILES           }
{   ARE CONFIDENTIAL AND PROPRIETARY TRADE                          }
{   SECRETS OF DEVELOPER EXPRESS INC. THE REGISTERED DEVELOPER IS   }
{   LICENSED TO DISTRIBUTE THE PRODUCT AND ALL ACCOMPANYING .NET    }
{   CONTROLS AS PART OF AN EXECUTABLE PROGRAM ONLY.                 }
{                                                                   }
{   THE SOURCE CODE CONTAINED WITHIN THIS FILE AND ALL RELATED      }
{   FILES OR ANY PORTION OF ITS CONTENTS SHALL AT NO TIME BE        }
{   COPIED, TRANSFERRED, SOLD, DISTRIBUTED, OR OTHERWISE MADE       }
{   AVAILABLE TO OTHER INDIVIDUALS WITHOUT EXPRESS WRITTEN CONSENT  }
{   AND PERMISSION FROM DEVELOPER EXPRESS INC.                      }
{                                                                   }
{   CONSULT THE END USER LICENSE AGREEMENT FOR INFORMATION ON       }
{   ADDITIONAL RESTRICTIONS.                                        }
{                                                                   }
{*******************************************************************}
*/
#endregion Copyright (c) 2000-2020 Developer Express Inc.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace DevExpress.Web.Demos {
	public class SearchAgregator {
		internal static StringComparison DefaultStringComparison = StringComparison.InvariantCultureIgnoreCase;
		static readonly string[] separators = new string[] { " ", ",", "/", "\\", "-", "+" };
		internal SearchAgregator(SearchModel searchModel) {
			SearchModel = searchModel;
		}
		string[] _requestExclusions;
		string[] _prefixes;
		string[] _postfixes;
		string[][] _synonyms;
		public string[] WordsExclusions {
			get {
				if(_requestExclusions == null)
					_requestExclusions = GetWordsExclusions(SearchModel);
				return _requestExclusions;
			}
		}
		static string[] GetWordsExclusions(SearchModel search) {
			return search.Exclusions.Words.Split(separators, StringSplitOptions.RemoveEmptyEntries);
		}
		public string[] PrefixesExclusions {
			get {
				if(_prefixes == null)
					_prefixes = GetPrefixesExclusions(SearchModel);
				return _prefixes;
			}
		}
		internal static string[] GetPrefixesExclusions(SearchModel search) {
			return search.Exclusions.Prefixes.Split(separators, StringSplitOptions.RemoveEmptyEntries);
		}
		public string[] PostfixesExclusions {
			get {
				if(_postfixes == null)
					_postfixes = GetPostfixesExclusions(SearchModel);
				return _postfixes;
			}
		}
		internal static string[] GetPostfixesExclusions(SearchModel search) {
			return search.Exclusions.Postfixes.Split(separators, StringSplitOptions.RemoveEmptyEntries);
		}
		public string[][] Synonyms {
			get {
				if(_synonyms == null)
					_synonyms = GetSynonyms(SearchModel);
				return _synonyms;
			}
		}
		internal static string[][] GetSynonyms(SearchModel search) {
			return search.Synonyms.Groups.Select(s => s.Split(separators, StringSplitOptions.RemoveEmptyEntries)).ToArray();
		}
		SearchModel SearchModel { get; set; }
		public static bool CalculateRank(string[] synonyms, Dictionary<string, int> keywordsRankList, out int rank) {
			var keyword = keywordsRankList.Keys.FirstOrDefault(k => MatchWord(synonyms[0], k));
			rank = keyword != null ? keywordsRankList[keyword] : -1;
			if(rank == -1) {
				foreach(var syn in synonyms.Skip(1)) {
					keyword = keywordsRankList.Keys.FirstOrDefault(k => MatchWord(syn, k));
					rank += keyword != null ? keywordsRankList[keyword] : -1;
					if(rank > -1)
						break;
				}
			}
			return rank > -1;
		}
		internal static string HighlightOccurences(string text, List<string[]> requests) {
			return HighlightOccurences(text, requests, false);
		}
		internal static string HighlightOccurences(string text, List<string[]> requests, bool combineMatches) {
			var validRequest = new Regex("[0-9a-zA-Z]{2,}", RegexOptions.IgnoreCase);
			foreach(var request in requests.SelectMany(r => r)) {
				if(validRequest.IsMatch(request)) {
					Regex re = new Regex("([a-zA-Z0-9]*" + request + "[a-zA-Z0-9]*)", RegexOptions.IgnoreCase);
					text = re.Replace(text, "<b>$0</b>");
				}
			}
			if(combineMatches) {
				Regex reCombine = new Regex("</b>\\s<b>", RegexOptions.IgnoreCase);
				text = reCombine.Replace(text, " ");
			}
			return text;
		}
		public List<string[]> SplitRequests(string request) {
			var words = request.Split(separators, StringSplitOptions.RemoveEmptyEntries);
			var result = new List<string[]>();
			foreach(var word in words) {
				var resultWord = PrepareWord(word);
				var synonymList = Synonyms.FirstOrDefault(list => list.Any(s => MatchWord(resultWord, s)));
				var wordSynonyms = new List<string>() { resultWord };
				if(synonymList != null)
					wordSynonyms.AddRange(synonymList.Where(s => !MatchWord(resultWord, s)));
				result.Add(wordSynonyms.Distinct().ToArray());
			}
			return result;
		}
		string PrepareWord(string word) {
			foreach(var prefix in PrefixesExclusions) {
				if(word.StartsWith(prefix, DefaultStringComparison) && word.Length > prefix.Length)
					word = word.Remove(0, prefix.Length);
			}
			foreach(var postfix in PostfixesExclusions) {
				if(word.EndsWith(postfix, DefaultStringComparison) && word.Length > postfix.Length)
					word = word.Substring(0, word.Length - postfix.Length);
			}
			return word;
		}
		static bool MatchWord(string request, string word) {
			return word.IndexOf(request, DefaultStringComparison) > -1;
		}
		internal static string[] GetKeywordsList(params string[] words) {
			return words
				.SelectMany(w => w.Split(separators, StringSplitOptions.RemoveEmptyEntries))
				.Distinct()
				.ToArray();
		}
		public Dictionary<string, int> GetKeywordsRankList(List<TextRank> textRanks) {
			var result = new Dictionary<string, int>();
			foreach(var textRank in textRanks) {
				var words = textRank.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
				foreach(var word in words) {
					var rankWord = PrepareWord(word);
					if(!result.ContainsKey(rankWord))
						result[rankWord] = textRank.Rank;
				}
			}
			return result.OrderByDescending(keyValuePair => keyValuePair.Value).ToDictionary(keyValuePair => keyValuePair.Key, keyValuePair => keyValuePair.Value);
		}
	}
	public class TextRank {
		public TextRank(string text, int rank) {
			this.Text = text;
			this.Rank = rank;
		}
		public string Text {
			get;
			set;
		}
		public int Rank {
			get;
			set;
		}
	}
}
