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
using Q482980 = AutorjesusOntology.Q482980;

namespace ObrajesusOntology
{
	[ExcludeFromCodeCoverage]
	public class Q47461344 : GnossOCBase
	{
		public Q47461344() : base() { } 

		public Q47461344(SemanticResourceModel pSemCmsModel, LanguageEnum idiomaUsuario) : base()
		{
			GNOSSID = pSemCmsModel.RootEntities[0].Entity.Uri;
			Wdt_P50 = new List<Q482980>();
			SemanticPropertyModel propWdt_P50 = pSemCmsModel.GetPropertyByPath("http://www.wikidata.org/prop/direct/P50");
			if(propWdt_P50 != null && propWdt_P50.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propWdt_P50.PropertyValues)
				{
					if(propValue.RelatedEntity!=null){
						Q482980 wdt_P50 = new Q482980(propValue.RelatedEntity,idiomaUsuario);
						Wdt_P50.Add(wdt_P50);
					}
				}
			}
			SemanticPropertyModel propSchema_genre = pSemCmsModel.GetPropertyByPath("http://schema.org/genre");
			this.Schema_genre = new List<string>();
			if (propSchema_genre != null && propSchema_genre.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propSchema_genre.PropertyValues)
				{
					this.Schema_genre.Add(propValue.Value);
				}
			}
			this.Schema_url = GetPropertyValueSemCms(pSemCmsModel.GetPropertyByPath("http://schema.org/url"));
			SemanticPropertyModel propSchema_image = pSemCmsModel.GetPropertyByPath("http://schema.org/image");
			this.Schema_image = new List<string>();
			if (propSchema_image != null && propSchema_image.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propSchema_image.PropertyValues)
				{
					this.Schema_image.Add(propValue.Value);
				}
			}
			this.Schema_tittle = GetPropertyValueSemCms(pSemCmsModel.GetPropertyByPath("http://schema.org/tittle"));
			this.Schema_datePublished = GetDateValuePropertySemCms(pSemCmsModel.GetPropertyByPath("http://schema.org/datePublished"));
		}

		public Q47461344(SemanticEntityModel pSemCmsModel, LanguageEnum idiomaUsuario) : base()
		{
			mGNOSSID = pSemCmsModel.Entity.Uri;
			mURL = pSemCmsModel.Properties.FirstOrDefault(p => p.PropertyValues.Any(prop => prop.DownloadUrl != null))?.FirstPropertyValue.DownloadUrl;
			Wdt_P50 = new List<Q482980>();
			SemanticPropertyModel propWdt_P50 = pSemCmsModel.GetPropertyByPath("http://www.wikidata.org/prop/direct/P50");
			if(propWdt_P50 != null && propWdt_P50.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propWdt_P50.PropertyValues)
				{
					if(propValue.RelatedEntity!=null){
						Q482980 wdt_P50 = new Q482980(propValue.RelatedEntity,idiomaUsuario);
						Wdt_P50.Add(wdt_P50);
					}
				}
			}
			SemanticPropertyModel propSchema_genre = pSemCmsModel.GetPropertyByPath("http://schema.org/genre");
			this.Schema_genre = new List<string>();
			if (propSchema_genre != null && propSchema_genre.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propSchema_genre.PropertyValues)
				{
					this.Schema_genre.Add(propValue.Value);
				}
			}
			this.Schema_url = GetPropertyValueSemCms(pSemCmsModel.GetPropertyByPath("http://schema.org/url"));
			SemanticPropertyModel propSchema_image = pSemCmsModel.GetPropertyByPath("http://schema.org/image");
			this.Schema_image = new List<string>();
			if (propSchema_image != null && propSchema_image.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propSchema_image.PropertyValues)
				{
					this.Schema_image.Add(propValue.Value);
				}
			}
			this.Schema_tittle = GetPropertyValueSemCms(pSemCmsModel.GetPropertyByPath("http://schema.org/tittle"));
			this.Schema_datePublished = GetDateValuePropertySemCms(pSemCmsModel.GetPropertyByPath("http://schema.org/datePublished"));
		}

		public virtual string RdfType { get { return "http://www.wikidata.org/entity/Q47461344"; } }
		public virtual string RdfsLabel { get { return "http://www.wikidata.org/entity/Q47461344"; } }
		[LABEL(LanguageEnum.en,"Author")]
		[LABEL(LanguageEnum.es,"Autor")]
		[RDFProperty("http://www.wikidata.org/prop/direct/P50")]
		public  List<Q482980> Wdt_P50 { get; set;}
		public List<string> IdsWdt_P50 { get; set;}

		[LABEL(LanguageEnum.en,"Genre")]
		[LABEL(LanguageEnum.es,"Genero")]
		[RDFProperty("http://schema.org/genre")]
		public  List<string> Schema_genre { get; set;}

		[LABEL(LanguageEnum.en,"uri")]
		[LABEL(LanguageEnum.es,"uri")]
		[RDFProperty("http://schema.org/url")]
		public  string Schema_url { get; set;}

		[LABEL(LanguageEnum.en,"Image")]
		[LABEL(LanguageEnum.es,"Imagen")]
		[RDFProperty("http://schema.org/image")]
		public  List<string> Schema_image { get; set;}

		[LABEL(LanguageEnum.en,"Tittle")]
		[LABEL(LanguageEnum.es,"Titulo")]
		[RDFProperty("http://schema.org/tittle")]
		public  string Schema_tittle { get; set;}

		[LABEL(LanguageEnum.en,"Date of publication")]
		[LABEL(LanguageEnum.es,"Fecha de publicacion")]
		[RDFProperty("http://schema.org/datePublished")]
		public  DateTime? Schema_datePublished { get; set;}


		internal override void GetProperties()
		{
			base.GetProperties();
			propList.Add(new ListStringOntologyProperty("wdt:P50", this.IdsWdt_P50));
			propList.Add(new ListStringOntologyProperty("schema:genre", this.Schema_genre));
			propList.Add(new StringOntologyProperty("schema:url", this.Schema_url));
			propList.Add(new StringOntologyProperty("schema:tittle", this.Schema_tittle));
			if (this.Schema_datePublished.HasValue){
				propList.Add(new DateOntologyProperty("schema:datePublished", this.Schema_datePublished.Value));
				}
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
			AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q47461344_{ResourceID}_{ArticleID}", "http://www.w3.org/1999/02/22-rdf-syntax-ns#type", $"<http://www.wikidata.org/entity/Q47461344>", list, " . ");
			AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q47461344_{ResourceID}_{ArticleID}", "http://www.w3.org/2000/01/rdf-schema#label", $"\"http://www.wikidata.org/entity/Q47461344\"", list, " . ");
			AgregarTripleALista($"{resourceAPI.GraphsUrl}{ResourceID}", "http://gnoss/hasEntidad", $"<{resourceAPI.GraphsUrl}items/Q47461344_{ResourceID}_{ArticleID}>", list, " . ");
				if(this.IdsWdt_P50 != null)
				{
					foreach(var item2 in this.IdsWdt_P50)
					{
						AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q47461344_{ResourceID}_{ArticleID}", "http://www.wikidata.org/prop/direct/P50", $"<{item2}>", list, " . ");
					}
				}
				if(this.Schema_genre != null)
				{
					foreach(var item2 in this.Schema_genre)
					{
						AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q47461344_{ResourceID}_{ArticleID}", "http://schema.org/genre", $"\"{GenerarTextoSinSaltoDeLinea(item2)}\"", list, " . ");
					}
				}
				if(this.Schema_url != null)
				{
					AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q47461344_{ResourceID}_{ArticleID}", "http://schema.org/url",  $"\"{GenerarTextoSinSaltoDeLinea(this.Schema_url)}\"", list, " . ");
				}
				if(this.Schema_image != null)
				{
					foreach(var item2 in this.Schema_image)
					{
						AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q47461344_{ResourceID}_{ArticleID}", "http://schema.org/image", $"\"{GenerarTextoSinSaltoDeLinea(item2)}\"", list, " . ");
					}
				}
				if(this.Schema_tittle != null)
				{
					AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q47461344_{ResourceID}_{ArticleID}", "http://schema.org/tittle",  $"\"{GenerarTextoSinSaltoDeLinea(this.Schema_tittle)}\"", list, " . ");
				}
				if(this.Schema_datePublished != null)
				{
					AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q47461344_{ResourceID}_{ArticleID}", "http://schema.org/datePublished",  $"\"{this.Schema_datePublished.Value.ToString("yyyyMMddHHmmss")}\"", list, " . ");
				}
			return list;
		}

		public override List<string> ToSearchGraphTriples(ResourceApi resourceAPI)
		{
			List<string> list = new List<string>();
			List<string> listaSearch = new List<string>();
			AgregarTags(list);
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://www.w3.org/1999/02/22-rdf-syntax-ns#type", $"\"obrajesus\"", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/type", $"\"http://www.wikidata.org/entity/Q47461344\"", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/hasfechapublicacion", $"{DateTime.Now.ToString("yyyyMMddHHmmss")}", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/hastipodoc", "\"5\"", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/hasfechamodificacion", $"{DateTime.Now.ToString("yyyyMMddHHmmss")}", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/hasnumeroVisitas", "0", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/hasprivacidadCom", "\"publico\"", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://xmlns.com/foaf/0.1/firstName", $"\"{GenerarTextoSinSaltoDeLinea(this.Schema_tittle)}\"", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/hasnombrecompleto", $"\"{GenerarTextoSinSaltoDeLinea(this.Schema_tittle)}\"", list, " . ");
			string search = string.Empty;
				if(this.IdsWdt_P50 != null)
				{
					foreach(var item2 in this.IdsWdt_P50)
					{
					Regex regex = new Regex(@"\/items\/.+_[0-9A-Fa-f]{8}[-]?(?:[0-9A-Fa-f]{4}[-]?){3}[0-9A-Fa-f]{12}_[0-9A-Fa-f]{8}[-]?(?:[0-9A-Fa-f]{4}[-]?){3}[0-9A-Fa-f]{12}");
					string itemRegex = item2;
					if (regex.IsMatch(itemRegex))
					{
						itemRegex = $"http://gnoss/{resourceAPI.GetShortGuid(itemRegex).ToString().ToUpper()}";
					}
					else
					{
						itemRegex = itemRegex.ToLower();
					}
						AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://www.wikidata.org/prop/direct/P50", $"<{itemRegex}>", list, " . ");
					}
				}
				if(this.Schema_genre != null)
				{
					foreach(var item2 in this.Schema_genre)
					{
						AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://schema.org/genre", $"\"{GenerarTextoSinSaltoDeLinea(item2)}\"", list, " . ");
					}
				}
				if(this.Schema_url != null)
				{
					AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://schema.org/url",  $"\"{GenerarTextoSinSaltoDeLinea(this.Schema_url)}\"", list, " . ");
				}
				if(this.Schema_image != null)
				{
					foreach(var item2 in this.Schema_image)
					{
						AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://schema.org/image", $"\"{GenerarTextoSinSaltoDeLinea(item2)}\"", list, " . ");
					}
				}
				if(this.Schema_tittle != null)
				{
					AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://schema.org/tittle",  $"\"{GenerarTextoSinSaltoDeLinea(this.Schema_tittle)}\"", list, " . ");
				}
				if(this.Schema_datePublished != null)
				{
					AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://schema.org/datePublished",  $"{this.Schema_datePublished.Value.ToString("yyyyMMddHHmmss")}", list, " . ");
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
			string titulo = $"{this.Schema_tittle.Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Replace("\"", "\"\"").Replace("'", "#COMILLA#").Replace("|", "#PIPE#")}";
			string descripcion = $"{this.Schema_tittle.Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Replace("\"", "\"\"").Replace("'", "#COMILLA#").Replace("|", "#PIPE#")}";
			string tablaDoc = $"'{titulo}', '{descripcion}', '{resourceAPI.GraphsUrl}', '{tags}'";
			KeyValuePair<Guid, string> valor = new KeyValuePair<Guid, string>(ResourceID, tablaDoc);

			return valor;
		}

		public override string GetURI(ResourceApi resourceAPI)
		{
			return $"{resourceAPI.GraphsUrl}items/ObrajesusOntology_{ResourceID}_{ArticleID}";
		}


		internal void AddResourceTitle(ComplexOntologyResource resource)
		{
			resource.Title = this.Schema_tittle;
		}

		internal void AddResourceDescription(ComplexOntologyResource resource)
		{
			resource.Description = this.Schema_tittle;
		}



		internal override void AddImages(ComplexOntologyResource pResource)
		{
			base.AddImages(pResource);
			if(this.Schema_image != null)
			{
				foreach(string prop in this.Schema_image)
				{
				List<ImageAction> actionListimage = new List<ImageAction>();
				bool principal=true;
				actionListimage.Add(new ImageAction(0,234, ImageTransformationType.Crop, 100));
				actionListimage.Add(new ImageAction(318,234, ImageTransformationType.ResizeToWidth, 100));
				actionListimage.Add(new ImageAction(992,234, ImageTransformationType.ResizeToWidth, 100));
				pResource.AttachImage(prop, actionListimage,"schema:image", principal, this.GetExtension(prop));
				principal = false;
				}
			}
		}

	}
}
