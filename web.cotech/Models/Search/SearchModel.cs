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
using System.Text;
using System.Xml.Serialization;
namespace DevExpress.Web {
	public class SearchModel {
		SynonymsSearchModel _synonyms;
		ExclusionsSearchModel _exclusions;
		[XmlElement]
		public SynonymsSearchModel Synonyms {
			get { return _synonyms; }
			set { _synonyms = value; }
		}
		[XmlElement]
		public ExclusionsSearchModel Exclusions {
			get { return _exclusions; }
			set { _exclusions = value; }
		}
	}
	public class ExclusionsSearchModel {
		string _words;
		string _prefixes;
		string _postfixes;
		[XmlElement]
		public string Words {
			get { return _words; }
			set { _words = value; }
		}
		[XmlElement]
		public string Prefixes {
			get { return _prefixes; }
			set { _prefixes = value; }
		}
		[XmlElement]
		public string Postfixes {
			get { return _postfixes; }
			set { _postfixes = value; }
		}
	}
	public class SynonymsSearchModel {
		List<string> _groups = new List<string>();
		[XmlElement("Group")]
		public List<string> Groups {
			get { return _groups; }
			set { _groups = value; }
		}
	}
}
