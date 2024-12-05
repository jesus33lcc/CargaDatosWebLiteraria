using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Gnoss.ApiWrapper;
using Gnoss.ApiWrapper.Model;
using Gnoss.ApiWrapper.Helpers;
using GnossBase;
using Es.Riam.Gnoss.Web.MVC.Models;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Collections;
using Gnoss.ApiWrapper.Exceptions;
using System.Diagnostics.CodeAnalysis;

namespace AutorjesusOntology
{
	[ExcludeFromCodeCoverage]
	public class Q98929991 : GnossOCBase
	{
		public Q98929991() : base() { } 

		public Q98929991(SemanticEntityModel pSemCmsModel, LanguageEnum idiomaUsuario) : base()
		{
			mGNOSSID = pSemCmsModel.Entity.Uri;
			mURL = pSemCmsModel.Properties.FirstOrDefault(p => p.PropertyValues.Any(prop => prop.DownloadUrl != null))?.FirstPropertyValue.DownloadUrl;
			this.Wdt_P17 = GetPropertyValueSemCms(pSemCmsModel.GetPropertyByPath("http://www.wikidata.org/prop/direct/P17"));
			this.Wdt_P30 = GetPropertyValueSemCms(pSemCmsModel.GetPropertyByPath("http://www.wikidata.org/prop/direct/P30"));
		}

		public virtual string RdfType { get { return "http://www.wikidata.org/entity/Q98929991"; } }
		public virtual string RdfsLabel { get { return "http://www.wikidata.org/entity/Q98929991"; } }
		public OntologyEntity Entity { get; set; }

		[LABEL(LanguageEnum.en,"Country")]
		[LABEL(LanguageEnum.es,"Pais")]
		[RDFProperty("http://www.wikidata.org/prop/direct/P17")]
		public  string Wdt_P17 { get; set;}

		[LABEL(LanguageEnum.en,"Continent")]
		[LABEL(LanguageEnum.es,"Continente")]
		[RDFProperty("http://www.wikidata.org/prop/direct/P30")]
		public  string Wdt_P30 { get; set;}


		internal override void GetProperties()
		{
			base.GetProperties();
			propList.Add(new StringOntologyProperty("wdt:P17", this.Wdt_P17));
			propList.Add(new StringOntologyProperty("wdt:P30", this.Wdt_P30));
		}

		internal override void GetEntities()
		{
			base.GetEntities();
		} 











	}
}
