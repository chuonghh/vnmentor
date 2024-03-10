#region Copyright (c) 2000-2020 Developer Express Inc.
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

using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
namespace DevExpress.Web.Demos {
	[XmlRoot("Themes")]
	public class BootstrapThemesModel {
		const string ResourceName = "Data.Bootstrap.Themes.xml";
		static BootstrapThemesModel _current;
		static readonly object _currentLock = new object();
		public static BootstrapThemesModel Current {
			get {
				lock(_currentLock) {
					if(_current == null) {
						using(Stream stream = ResourcesUtils.GetEmbeddedResource(ResourceName)) {
							XmlSerializer serializer = new XmlSerializer(typeof(BootstrapThemesModel));
							_current = (BootstrapThemesModel)serializer.Deserialize(stream);
						}
					}
					return _current;
				}
			}
		}
		List<ThemeModelBase> _themes = new List<ThemeModelBase>();
		List<ThemeModelBase> _themes4 = new List<ThemeModelBase>();
		[XmlElement("Theme")]
		public List<ThemeModelBase> Themes {
			get { return _themes; }
		}
		[XmlElement("Theme4")]
		public List<ThemeModelBase> Themes4 {
			get { return _themes4; }
		}
	}
}
