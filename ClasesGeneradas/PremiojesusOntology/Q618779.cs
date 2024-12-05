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

namespace PremiojesusOntology
{
	[ExcludeFromCodeCoverage]
	public class Q618779 : GnossOCBase
	{
		public Q618779() : base() { } 

		public Q618779(SemanticResourceModel pSemCmsModel, LanguageEnum idiomaUsuario) : base()
		{
			GNOSSID = pSemCmsModel.RootEntities[0].Entity.Uri;
			SemanticPropertyModel propWdt_P17 = pSemCmsModel.GetPropertyByPath("http://www.wikidata.org/prop/direct/P17");
			this.Wdt_P17 = new List<string>();
			if (propWdt_P17 != null && propWdt_P17.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propWdt_P17.PropertyValues)
				{
					this.Wdt_P17.Add(propValue.Value);
				}
			}
			this.Schema_url = GetPropertyValueSemCms(pSemCmsModel.GetPropertyByPath("http://schema.org/url"));
			this.Schema_name = GetPropertyValueSemCms(pSemCmsModel.GetPropertyByPath("http://schema.org/name"));
		}

		public Q618779(SemanticEntityModel pSemCmsModel, LanguageEnum idiomaUsuario) : base()
		{
			mGNOSSID = pSemCmsModel.Entity.Uri;
			mURL = pSemCmsModel.Properties.FirstOrDefault(p => p.PropertyValues.Any(prop => prop.DownloadUrl != null))?.FirstPropertyValue.DownloadUrl;
			SemanticPropertyModel propWdt_P17 = pSemCmsModel.GetPropertyByPath("http://www.wikidata.org/prop/direct/P17");
			this.Wdt_P17 = new List<string>();
			if (propWdt_P17 != null && propWdt_P17.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propWdt_P17.PropertyValues)
				{
					this.Wdt_P17.Add(propValue.Value);
				}
			}
			this.Schema_url = GetPropertyValueSemCms(pSemCmsModel.GetPropertyByPath("http://schema.org/url"));
			this.Schema_name = GetPropertyValueSemCms(pSemCmsModel.GetPropertyByPath("http://schema.org/name"));
		}

		public virtual string RdfType { get { return "http://www.wikidata.org/entity/Q618779"; } }
		public virtual string RdfsLabel { get { return "http://www.wikidata.org/entity/Q618779"; } }
		[LABEL(LanguageEnum.es,"Pais")]
		[LABEL(LanguageEnum.en,"Country")]
		[RDFProperty("http://www.wikidata.org/prop/direct/P17")]
		public  List<string> Wdt_P17 { get; set;}

		[LABEL(LanguageEnum.es,"uri")]
		[LABEL(LanguageEnum.en,"uri")]
		[RDFProperty("http://schema.org/url")]
		public  string Schema_url { get; set;}

		[LABEL(LanguageEnum.es,"Nombre")]
		[LABEL(LanguageEnum.en,"Name")]
		[RDFProperty("http://schema.org/name")]
		public  string Schema_name { get; set;}


		internal override void GetProperties()
		{
			base.GetProperties();
			propList.Add(new ListStringOntologyProperty("wdt:P17", this.Wdt_P17));
			propList.Add(new StringOntologyProperty("schema:url", this.Schema_url));
			propList.Add(new StringOntologyProperty("schema:name", this.Schema_name));
		}

		internal override void GetEntities()
		{
			base.GetEntities();
		} 
		public virtual ComplexOntologyResource ToGnossApiResource(ResourceApi resourceAPI)
		{
			return ToGnossApiResource(resourceAPI, new List<string>());
		}

		public virtual ComplexOntologyResource ToGnossApiResource(ResourceApi resourceAPI, List<string> listaDeCategorias)
		{
			return ToGnossApiResource(resourceAPI, listaDeCategorias, Guid.Empty, Guid.Empty);
		}

		public virtual ComplexOntologyResource ToGnossApiResource(ResourceApi resourceAPI, List<Guid> listaDeCategorias)
		{
			return ToGnossApiResource(resourceAPI, null, Guid.Empty, Guid.Empty, listaDeCategorias);
		}

		public virtual ComplexOntologyResource ToGnossApiResource(ResourceApi resourceAPI, List<string> listaDeCategorias, Guid idrecurso, Guid idarticulo, List<Guid> listaIdDeCategorias = null)
		{
			ComplexOntologyResource resource = new ComplexOntologyResource();
			Ontology ontology = null;
			GetProperties();
			if(idrecurso.Equals(Guid.Empty) && idarticulo.Equals(Guid.Empty))
			{
				ontology = new Ontology(resourceAPI.GraphsUrl, resourceAPI.OntologyUrl, RdfType, RdfsLabel, prefList, propList, entList);
			}
			else{
				ontology = new Ontology(resourceAPI.GraphsUrl, resourceAPI.OntologyUrl, RdfType, RdfsLabel, prefList, propList, entList,idrecurso,idarticulo);
			}
			resource.Id = GNOSSID;
			resource.Ontology = ontology;
			resource.TextCategories = listaDeCategorias;
			resource.CategoriesIds = listaIdDeCategorias;
			AddResourceTitle(resource);
			AddResourceDescription(resource);
			AddImages(resource);
			AddFiles(resource);
			return resource;
		}

		public override List<string> ToOntologyGnossTriples(ResourceApi resourceAPI)
		{
			List<string> list = new List<string>();
			AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q618779_{ResourceID}_{ArticleID}", "http://www.w3.org/1999/02/22-rdf-syntax-ns#type", $"<http://www.wikidata.org/entity/Q618779>", list, " . ");
			AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q618779_{ResourceID}_{ArticleID}", "http://www.w3.org/2000/01/rdf-schema#label", $"\"http://www.wikidata.org/entity/Q618779\"", list, " . ");
			AgregarTripleALista($"{resourceAPI.GraphsUrl}{ResourceID}", "http://gnoss/hasEntidad", $"<{resourceAPI.GraphsUrl}items/Q618779_{ResourceID}_{ArticleID}>", list, " . ");
				if(this.Wdt_P17 != null)
				{
					foreach(var item2 in this.Wdt_P17)
					{
						AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q618779_{ResourceID}_{ArticleID}", "http://www.wikidata.org/prop/direct/P17", $"\"{GenerarTextoSinSaltoDeLinea(item2)}\"", list, " . ");
					}
				}
				if(this.Schema_url != null)
				{
					AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q618779_{ResourceID}_{ArticleID}", "http://schema.org/url",  $"\"{GenerarTextoSinSaltoDeLinea(this.Schema_url)}\"", list, " . ");
				}
				if(this.Schema_name != null)
				{
					AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q618779_{ResourceID}_{ArticleID}", "http://schema.org/name",  $"\"{GenerarTextoSinSaltoDeLinea(this.Schema_name)}\"", list, " . ");
				}
			return list;
		}

		public override List<string> ToSearchGraphTriples(ResourceApi resourceAPI)
		{
			List<string> list = new List<string>();
			List<string> listaSearch = new List<string>();
			AgregarTags(list);
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://www.w3.org/1999/02/22-rdf-syntax-ns#type", $"\"premiojesus\"", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/type", $"\"http://www.wikidata.org/entity/Q618779\"", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/hasfechapublicacion", $"{DateTime.Now.ToString("yyyyMMddHHmmss")}", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/hastipodoc", "\"5\"", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/hasfechamodificacion", $"{DateTime.Now.ToString("yyyyMMddHHmmss")}", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/hasnumeroVisitas", "0", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/hasprivacidadCom", "\"publico\"", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://xmlns.com/foaf/0.1/firstName", $"\"{GenerarTextoSinSaltoDeLinea(this.Schema_name)}\"", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/hasnombrecompleto", $"\"{GenerarTextoSinSaltoDeLinea(this.Schema_name)}\"", list, " . ");
			string search = string.Empty;
				if(this.Wdt_P17 != null)
				{
					foreach(var item2 in this.Wdt_P17)
					{
						AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://www.wikidata.org/prop/direct/P17", $"\"{GenerarTextoSinSaltoDeLinea(item2)}\"", list, " . ");
					}
				}
				if(this.Schema_url != null)
				{
					AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://schema.org/url",  $"\"{GenerarTextoSinSaltoDeLinea(this.Schema_url)}\"", list, " . ");
				}
				if(this.Schema_name != null)
				{
					AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://schema.org/name",  $"\"{GenerarTextoSinSaltoDeLinea(this.Schema_name)}\"", list, " . ");
				}
			if (listaSearch != null && listaSearch.Count > 0)
			{
				foreach(string valorSearch in listaSearch)
				{
					search += $"{valorSearch} ";
				}
			}
			if(!string.IsNullOrEmpty(search))
			{
				AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/search", $"\"{GenerarTextoSinSaltoDeLinea(search.ToLower())}\"", list, " . ");
			}
			return list;
		}

		public override KeyValuePair<Guid, string> ToAcidData(ResourceApi resourceAPI)
		{

			//Insert en la tabla Documento
			string tags = "";
			foreach(string tag in tagList)
			{
				tags += $"{tag}, ";
			}
			if (!string.IsNullOrEmpty(tags))
			{
				tags = tags.Substring(0, tags.LastIndexOf(','));
			}
			string titulo = $"{this.Schema_name.Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Replace("\"", "\"\"").Replace("'", "#COMILLA#").Replace("|", "#PIPE#")}";
			string descripcion = $"{this.Schema_name.Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Replace("\"", "\"\"").Replace("'", "#COMILLA#").Replace("|", "#PIPE#")}";
			string tablaDoc = $"'{titulo}', '{descripcion}', '{resourceAPI.GraphsUrl}', '{tags}'";
			KeyValuePair<Guid, string> valor = new KeyValuePair<Guid, string>(ResourceID, tablaDoc);

			return valor;
		}

		public override string GetURI(ResourceApi resourceAPI)
		{
			return $"{resourceAPI.GraphsUrl}items/PremiojesusOntology_{ResourceID}_{ArticleID}";
		}


		internal void AddResourceTitle(ComplexOntologyResource resource)
		{
			resource.Title = this.Schema_name;
		}

		internal void AddResourceDescription(ComplexOntologyResource resource)
		{
			resource.Description = this.Schema_name;
		}




	}
}
