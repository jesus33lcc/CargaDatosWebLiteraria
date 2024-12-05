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
using Q47461344 = ObrajesusOntology.Q47461344;
using Q618779 = PremiojesusOntology.Q618779;

namespace AutorjesusOntology
{
	[ExcludeFromCodeCoverage]
	public class Q482980 : GnossOCBase
	{
		public Q482980() : base() { } 

		public Q482980(SemanticResourceModel pSemCmsModel, LanguageEnum idiomaUsuario) : base()
		{
			GNOSSID = pSemCmsModel.RootEntities[0].Entity.Uri;
			Wdt_P800 = new List<Q47461344>();
			SemanticPropertyModel propWdt_P800 = pSemCmsModel.GetPropertyByPath("http://www.wikidata.org/prop/direct/P800");
			if(propWdt_P800 != null && propWdt_P800.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propWdt_P800.PropertyValues)
				{
					if(propValue.RelatedEntity!=null){
						Q47461344 wdt_P800 = new Q47461344(propValue.RelatedEntity,idiomaUsuario);
						Wdt_P800.Add(wdt_P800);
					}
				}
			}
			Wdt_P276 = new List<Q98929991>();
			SemanticPropertyModel propWdt_P276 = pSemCmsModel.GetPropertyByPath("http://www.wikidata.org/prop/direct/P276");
			if(propWdt_P276 != null && propWdt_P276.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propWdt_P276.PropertyValues)
				{
					if(propValue.RelatedEntity!=null){
						Q98929991 wdt_P276 = new Q98929991(propValue.RelatedEntity,idiomaUsuario);
						Wdt_P276.Add(wdt_P276);
					}
				}
			}
			Wdt_P166 = new List<Q618779>();
			SemanticPropertyModel propWdt_P166 = pSemCmsModel.GetPropertyByPath("http://www.wikidata.org/prop/direct/P166");
			if(propWdt_P166 != null && propWdt_P166.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propWdt_P166.PropertyValues)
				{
					if(propValue.RelatedEntity!=null){
						Q618779 wdt_P166 = new Q618779(propValue.RelatedEntity,idiomaUsuario);
						Wdt_P166.Add(wdt_P166);
					}
				}
			}
			this.Schema_gender = GetPropertyValueSemCms(pSemCmsModel.GetPropertyByPath("http://schema.org/gender"));
			SemanticPropertyModel propWdt_P106 = pSemCmsModel.GetPropertyByPath("http://www.wikidata.org/prop/direct/P106");
			this.Wdt_P106 = new List<string>();
			if (propWdt_P106 != null && propWdt_P106.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propWdt_P106.PropertyValues)
				{
					this.Wdt_P106.Add(propValue.Value);
				}
			}
			SemanticPropertyModel propSchema_image = pSemCmsModel.GetPropertyByPath("http://schema.org/image");
			this.Schema_image = new List<string>();
			if (propSchema_image != null && propSchema_image.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propSchema_image.PropertyValues)
				{
					this.Schema_image.Add(propValue.Value);
				}
			}
			this.Schema_url = GetPropertyValueSemCms(pSemCmsModel.GetPropertyByPath("http://schema.org/url"));
			this.Schema_name = GetPropertyValueSemCms(pSemCmsModel.GetPropertyByPath("http://schema.org/name"));
			SemanticPropertyModel propWdt_P135 = pSemCmsModel.GetPropertyByPath("http://www.wikidata.org/prop/direct/P135");
			this.Wdt_P135 = new List<string>();
			if (propWdt_P135 != null && propWdt_P135.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propWdt_P135.PropertyValues)
				{
					this.Wdt_P135.Add(propValue.Value);
				}
			}
		}

		public Q482980(SemanticEntityModel pSemCmsModel, LanguageEnum idiomaUsuario) : base()
		{
			mGNOSSID = pSemCmsModel.Entity.Uri;
			mURL = pSemCmsModel.Properties.FirstOrDefault(p => p.PropertyValues.Any(prop => prop.DownloadUrl != null))?.FirstPropertyValue.DownloadUrl;
			Wdt_P800 = new List<Q47461344>();
			SemanticPropertyModel propWdt_P800 = pSemCmsModel.GetPropertyByPath("http://www.wikidata.org/prop/direct/P800");
			if(propWdt_P800 != null && propWdt_P800.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propWdt_P800.PropertyValues)
				{
					if(propValue.RelatedEntity!=null){
						Q47461344 wdt_P800 = new Q47461344(propValue.RelatedEntity,idiomaUsuario);
						Wdt_P800.Add(wdt_P800);
					}
				}
			}
			Wdt_P276 = new List<Q98929991>();
			SemanticPropertyModel propWdt_P276 = pSemCmsModel.GetPropertyByPath("http://www.wikidata.org/prop/direct/P276");
			if(propWdt_P276 != null && propWdt_P276.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propWdt_P276.PropertyValues)
				{
					if(propValue.RelatedEntity!=null){
						Q98929991 wdt_P276 = new Q98929991(propValue.RelatedEntity,idiomaUsuario);
						Wdt_P276.Add(wdt_P276);
					}
				}
			}
			Wdt_P166 = new List<Q618779>();
			SemanticPropertyModel propWdt_P166 = pSemCmsModel.GetPropertyByPath("http://www.wikidata.org/prop/direct/P166");
			if(propWdt_P166 != null && propWdt_P166.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propWdt_P166.PropertyValues)
				{
					if(propValue.RelatedEntity!=null){
						Q618779 wdt_P166 = new Q618779(propValue.RelatedEntity,idiomaUsuario);
						Wdt_P166.Add(wdt_P166);
					}
				}
			}
			this.Schema_gender = GetPropertyValueSemCms(pSemCmsModel.GetPropertyByPath("http://schema.org/gender"));
			SemanticPropertyModel propWdt_P106 = pSemCmsModel.GetPropertyByPath("http://www.wikidata.org/prop/direct/P106");
			this.Wdt_P106 = new List<string>();
			if (propWdt_P106 != null && propWdt_P106.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propWdt_P106.PropertyValues)
				{
					this.Wdt_P106.Add(propValue.Value);
				}
			}
			SemanticPropertyModel propSchema_image = pSemCmsModel.GetPropertyByPath("http://schema.org/image");
			this.Schema_image = new List<string>();
			if (propSchema_image != null && propSchema_image.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propSchema_image.PropertyValues)
				{
					this.Schema_image.Add(propValue.Value);
				}
			}
			this.Schema_url = GetPropertyValueSemCms(pSemCmsModel.GetPropertyByPath("http://schema.org/url"));
			this.Schema_name = GetPropertyValueSemCms(pSemCmsModel.GetPropertyByPath("http://schema.org/name"));
			SemanticPropertyModel propWdt_P135 = pSemCmsModel.GetPropertyByPath("http://www.wikidata.org/prop/direct/P135");
			this.Wdt_P135 = new List<string>();
			if (propWdt_P135 != null && propWdt_P135.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propWdt_P135.PropertyValues)
				{
					this.Wdt_P135.Add(propValue.Value);
				}
			}
		}

		public virtual string RdfType { get { return "http://www.wikidata.org/entity/Q482980"; } }
		public virtual string RdfsLabel { get { return "http://www.wikidata.org/entity/Q482980"; } }
		[LABEL(LanguageEnum.en,"Notable work")]
		[LABEL(LanguageEnum.es,"Obra destacable")]
		[RDFProperty("http://www.wikidata.org/prop/direct/P800")]
		public  List<Q47461344> Wdt_P800 { get; set;}
		public List<string> IdsWdt_P800 { get; set;}

		[LABEL(LanguageEnum.en,"Location")]
		[LABEL(LanguageEnum.es,"Lugar")]
		[RDFProperty("http://www.wikidata.org/prop/direct/P276")]
		public  List<Q98929991> Wdt_P276 { get; set;}

		[LABEL(LanguageEnum.es,"Received award")]
		[LABEL(LanguageEnum.en,"Premio recibido")]
		[RDFProperty("http://www.wikidata.org/prop/direct/P166")]
		public  List<Q618779> Wdt_P166 { get; set;}
		public List<string> IdsWdt_P166 { get; set;}

		[LABEL(LanguageEnum.en,"Gender")]
		[LABEL(LanguageEnum.es,"Genero")]
		[RDFProperty("http://schema.org/gender")]
		public  string Schema_gender { get; set;}

		[LABEL(LanguageEnum.en,"Occupation")]
		[LABEL(LanguageEnum.es,"Ocupacion")]
		[RDFProperty("http://www.wikidata.org/prop/direct/P106")]
		public  List<string> Wdt_P106 { get; set;}

		[LABEL(LanguageEnum.en,"Image")]
		[LABEL(LanguageEnum.es,"Imagen")]
		[RDFProperty("http://schema.org/image")]
		public  List<string> Schema_image { get; set;}

		[LABEL(LanguageEnum.en,"uri")]
		[LABEL(LanguageEnum.es,"uri")]
		[RDFProperty("http://schema.org/url")]
		public  string Schema_url { get; set;}

		[LABEL(LanguageEnum.en,"Name")]
		[LABEL(LanguageEnum.es,"Nombre")]
		[RDFProperty("http://schema.org/name")]
		public  string Schema_name { get; set;}

		[LABEL(LanguageEnum.en,"Movement")]
		[LABEL(LanguageEnum.es,"Movimiento")]
		[RDFProperty("http://www.wikidata.org/prop/direct/P135")]
		public  List<string> Wdt_P135 { get; set;}


		internal override void GetProperties()
		{
			base.GetProperties();
			propList.Add(new ListStringOntologyProperty("wdt:P800", this.IdsWdt_P800));
			propList.Add(new ListStringOntologyProperty("wdt:P166", this.IdsWdt_P166));
			propList.Add(new StringOntologyProperty("schema:gender", this.Schema_gender));
			propList.Add(new ListStringOntologyProperty("wdt:P106", this.Wdt_P106));
			propList.Add(new StringOntologyProperty("schema:url", this.Schema_url));
			propList.Add(new StringOntologyProperty("schema:name", this.Schema_name));
			propList.Add(new ListStringOntologyProperty("wdt:P135", this.Wdt_P135));
		}

		internal override void GetEntities()
		{
			base.GetEntities();
			if(Wdt_P276!=null){
				foreach(Q98929991 prop in Wdt_P276){
					prop.GetProperties();
					prop.GetEntities();
					OntologyEntity entityQ98929991 = new OntologyEntity("http://www.wikidata.org/entity/Q98929991", "http://www.wikidata.org/entity/Q98929991", "wdt:P276", prop.propList, prop.entList);
				entList.Add(entityQ98929991);
				prop.Entity = entityQ98929991;
				}
			}
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
			GetEntities();
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
			AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q482980_{ResourceID}_{ArticleID}", "http://www.w3.org/1999/02/22-rdf-syntax-ns#type", $"<http://www.wikidata.org/entity/Q482980>", list, " . ");
			AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q482980_{ResourceID}_{ArticleID}", "http://www.w3.org/2000/01/rdf-schema#label", $"\"http://www.wikidata.org/entity/Q482980\"", list, " . ");
			AgregarTripleALista($"{resourceAPI.GraphsUrl}{ResourceID}", "http://gnoss/hasEntidad", $"<{resourceAPI.GraphsUrl}items/Q482980_{ResourceID}_{ArticleID}>", list, " . ");
			if(this.Wdt_P276 != null)
			{
			foreach(var item0 in this.Wdt_P276)
			{
				AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q98929991_{ResourceID}_{item0.ArticleID}", "http://www.w3.org/1999/02/22-rdf-syntax-ns#type", $"<http://www.wikidata.org/entity/Q98929991>", list, " . ");
				AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q98929991_{ResourceID}_{item0.ArticleID}", "http://www.w3.org/2000/01/rdf-schema#label", $"\"http://www.wikidata.org/entity/Q98929991\"", list, " . ");
				AgregarTripleALista($"{resourceAPI.GraphsUrl}{ResourceID}", "http://gnoss/hasEntidad", $"<{resourceAPI.GraphsUrl}items/Q98929991_{ResourceID}_{item0.ArticleID}>", list, " . ");
				AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q482980_{ResourceID}_{ArticleID}", "http://www.wikidata.org/prop/direct/P276", $"<{resourceAPI.GraphsUrl}items/Q98929991_{ResourceID}_{item0.ArticleID}>", list, " . ");
				if(item0.Wdt_P17 != null)
				{
					AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q98929991_{ResourceID}_{item0.ArticleID}", "http://www.wikidata.org/prop/direct/P17",  $"\"{GenerarTextoSinSaltoDeLinea(item0.Wdt_P17)}\"", list, " . ");
				}
				if(item0.Wdt_P30 != null)
				{
					AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q98929991_{ResourceID}_{item0.ArticleID}", "http://www.wikidata.org/prop/direct/P30",  $"\"{GenerarTextoSinSaltoDeLinea(item0.Wdt_P30)}\"", list, " . ");
				}
			}
			}
				if(this.IdsWdt_P800 != null)
				{
					foreach(var item2 in this.IdsWdt_P800)
					{
						AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q482980_{ResourceID}_{ArticleID}", "http://www.wikidata.org/prop/direct/P800", $"<{item2}>", list, " . ");
					}
				}
				if(this.IdsWdt_P166 != null)
				{
					foreach(var item2 in this.IdsWdt_P166)
					{
						AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q482980_{ResourceID}_{ArticleID}", "http://www.wikidata.org/prop/direct/P166", $"<{item2}>", list, " . ");
					}
				}
				if(this.Schema_gender != null)
				{
					AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q482980_{ResourceID}_{ArticleID}", "http://schema.org/gender",  $"\"{GenerarTextoSinSaltoDeLinea(this.Schema_gender)}\"", list, " . ");
				}
				if(this.Wdt_P106 != null)
				{
					foreach(var item2 in this.Wdt_P106)
					{
						AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q482980_{ResourceID}_{ArticleID}", "http://www.wikidata.org/prop/direct/P106", $"\"{GenerarTextoSinSaltoDeLinea(item2)}\"", list, " . ");
					}
				}
				if(this.Schema_image != null)
				{
					foreach(var item2 in this.Schema_image)
					{
						AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q482980_{ResourceID}_{ArticleID}", "http://schema.org/image", $"\"{GenerarTextoSinSaltoDeLinea(item2)}\"", list, " . ");
					}
				}
				if(this.Schema_url != null)
				{
					AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q482980_{ResourceID}_{ArticleID}", "http://schema.org/url",  $"\"{GenerarTextoSinSaltoDeLinea(this.Schema_url)}\"", list, " . ");
				}
				if(this.Schema_name != null)
				{
					AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q482980_{ResourceID}_{ArticleID}", "http://schema.org/name",  $"\"{GenerarTextoSinSaltoDeLinea(this.Schema_name)}\"", list, " . ");
				}
				if(this.Wdt_P135 != null)
				{
					foreach(var item2 in this.Wdt_P135)
					{
						AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q482980_{ResourceID}_{ArticleID}", "http://www.wikidata.org/prop/direct/P135", $"\"{GenerarTextoSinSaltoDeLinea(item2)}\"", list, " . ");
					}
				}
			return list;
		}

		public override List<string> ToSearchGraphTriples(ResourceApi resourceAPI)
		{
			List<string> list = new List<string>();
			List<string> listaSearch = new List<string>();
			AgregarTags(list);
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://www.w3.org/1999/02/22-rdf-syntax-ns#type", $"\"autorjesus\"", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/type", $"\"http://www.wikidata.org/entity/Q482980\"", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/hasfechapublicacion", $"{DateTime.Now.ToString("yyyyMMddHHmmss")}", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/hastipodoc", "\"5\"", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/hasfechamodificacion", $"{DateTime.Now.ToString("yyyyMMddHHmmss")}", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/hasnumeroVisitas", "0", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/hasprivacidadCom", "\"publico\"", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://xmlns.com/foaf/0.1/firstName", $"\"{GenerarTextoSinSaltoDeLinea(this.Schema_name)}\"", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/hasnombrecompleto", $"\"{GenerarTextoSinSaltoDeLinea(this.Schema_name)}\"", list, " . ");
			string search = string.Empty;
			if(this.Wdt_P276 != null)
			{
			foreach(var item0 in this.Wdt_P276)
			{
				AgregarTripleALista($"http://gnossAuxiliar/{ResourceID.ToString().ToUpper()}", "http://gnoss/hasEntidadAuxiliar", $"<{resourceAPI.GraphsUrl}items/Q98929991_{ResourceID}_{item0.ArticleID}>", list, " . ");
				AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://www.wikidata.org/prop/direct/P276", $"<{resourceAPI.GraphsUrl}items/Q98929991_{ResourceID}_{item0.ArticleID}>", list, " . ");
				if(item0.Wdt_P17 != null)
				{
					AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q98929991_{ResourceID}_{item0.ArticleID}", "http://www.wikidata.org/prop/direct/P17",  $"\"{GenerarTextoSinSaltoDeLinea(item0.Wdt_P17)}\"", list, " . ");
				}
				if(item0.Wdt_P30 != null)
				{
					AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Q98929991_{ResourceID}_{item0.ArticleID}", "http://www.wikidata.org/prop/direct/P30",  $"\"{GenerarTextoSinSaltoDeLinea(item0.Wdt_P30)}\"", list, " . ");
				}
			}
			}
				if(this.IdsWdt_P800 != null)
				{
					foreach(var item2 in this.IdsWdt_P800)
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
						AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://www.wikidata.org/prop/direct/P800", $"<{itemRegex}>", list, " . ");
					}
				}
				if(this.IdsWdt_P166 != null)
				{
					foreach(var item2 in this.IdsWdt_P166)
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
						AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://www.wikidata.org/prop/direct/P166", $"<{itemRegex}>", list, " . ");
					}
				}
				if(this.Schema_gender != null)
				{
					AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://schema.org/gender",  $"\"{GenerarTextoSinSaltoDeLinea(this.Schema_gender)}\"", list, " . ");
				}
				if(this.Wdt_P106 != null)
				{
					foreach(var item2 in this.Wdt_P106)
					{
						AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://www.wikidata.org/prop/direct/P106", $"\"{GenerarTextoSinSaltoDeLinea(item2)}\"", list, " . ");
					}
				}
				if(this.Schema_image != null)
				{
					foreach(var item2 in this.Schema_image)
					{
						AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://schema.org/image", $"\"{GenerarTextoSinSaltoDeLinea(item2)}\"", list, " . ");
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
				if(this.Wdt_P135 != null)
				{
					foreach(var item2 in this.Wdt_P135)
					{
						AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://www.wikidata.org/prop/direct/P135", $"\"{GenerarTextoSinSaltoDeLinea(item2)}\"", list, " . ");
					}
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
			return $"{resourceAPI.GraphsUrl}items/AutorjesusOntology_{ResourceID}_{ArticleID}";
		}


		internal void AddResourceTitle(ComplexOntologyResource resource)
		{
			resource.Title = this.Schema_name;
		}

		internal void AddResourceDescription(ComplexOntologyResource resource)
		{
			resource.Description = this.Schema_name;
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
			if(Wdt_P276 != null)
			{
				foreach (Q98929991 prop in Wdt_P276)
				{
					prop.AddImages(pResource);
				}
			}
		}

	}
}
