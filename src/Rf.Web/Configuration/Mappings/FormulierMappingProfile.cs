using AutoMapper;
using Rf.Domain;
using Rf.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rf.Web.Configuration.Mappings
{
    public class FormulierMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Formulier, FormulierModel>();
            Mapper.CreateMap<Persoon, PersoonModel>();
            Mapper.CreateMap<Afdeling, AfdelingModel>();
            Mapper.CreateMap<HoofdCode, HoofdCodeModel>();
            Mapper.CreateMap<SoortKlacht, SoortKlachtModel>();
            Mapper.CreateMap<Voertuig, VoertuigModel>();
            Mapper.CreateMap<Oorzaak, OorzaakModel>();
            Mapper.CreateMap<DetailCode, DetailCodeModel>();
            Mapper.CreateMap<Klant, KlantModel>();
            Mapper.CreateMap<QualityProcedure, QualityProcedureModel>();
            Mapper.CreateMap<Unit, UnitModel>();
            Mapper.CreateMap<Oorsprong, OorsprongModel>();
            Mapper.CreateMap<Ca, CaModel>();
            Mapper.CreateMap<Bestemming, BestemmingModel>();
            Mapper.CreateMap<Locatie, LocatieModel>();
            Mapper.CreateMap<Betrokkene, BetrokkeneModel>();
            Mapper.CreateMap<Rp, RpModel>();

            Mapper.CreateMap<FormulierModel, Formulier>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.TypeRf, opt => opt.Ignore())
                .ForMember(dest => dest.Afdeling, opt => opt.Ignore())
                .ForMember(dest => dest.Bestemmingen, opt => opt.Ignore())
                .ForMember(dest => dest.Betrokkenen, opt => opt.Ignore())
                .ForMember(dest => dest.Cas, opt => opt.Ignore())
                .ForMember(dest => dest.DetailCode, opt => opt.Ignore())
                .ForMember(dest => dest.HoofdCode, opt => opt.Ignore())
                .ForMember(dest => dest.Klanten, opt => opt.Ignore())
                .ForMember(dest => dest.Locaties, opt => opt.Ignore())
                .ForMember(dest => dest.Ontvanger, opt => opt.Ignore())
                .ForMember(dest => dest.OntvangerQL, opt => opt.Ignore())
                .ForMember(dest => dest.Oorsprongen, opt => opt.Ignore())
                .ForMember(dest => dest.Oorzaken, opt => opt.Ignore())
                .ForMember(dest => dest.Opsteller, opt => opt.Ignore())
                .ForMember(dest => dest.Procestype, opt => opt.Ignore())
                .ForMember(dest => dest.QualityProcedure, opt => opt.Ignore())
                .ForMember(dest => dest.Rp, opt => opt.Ignore())
                .ForMember(dest => dest.Soorten, opt => opt.Ignore())
                .ForMember(dest => dest.Soortklacht, opt => opt.Ignore())
                .ForMember(dest => dest.Unit, opt => opt.Ignore())
                .ForMember(dest => dest.Voertuig, opt => opt.Ignore());

            //Mapper.CreateMap<PersoonModel, Persoon>()
            //    .ForMember(dest => dest.Id, opt => opt.Ignore());
            //Mapper.CreateMap<AfdelingModel, Afdeling>()
            //    .ForMember(dest => dest.Id, opt => opt.Ignore());
            //Mapper.CreateMap<HoofdCodeModel, HoofdCode>()
            //    .ForMember(dest => dest.Id, opt => opt.Ignore());
            //Mapper.CreateMap<SoortKlachtModel, SoortKlacht>()
            //    .ForMember(dest => dest.Id, opt => opt.Ignore());
            //Mapper.CreateMap<VoertuigModel, Voertuig>()
            //    .ForMember(dest => dest.Id, opt => opt.Ignore());
            //Mapper.CreateMap<OorzaakModel, Oorzaak>()
            //    .ForMember(dest => dest.Id, opt => opt.Ignore());
            //Mapper.CreateMap<DetailCodeModel, DetailCode>()
            //    .ForMember(dest => dest.Id, opt => opt.Ignore());
            //Mapper.CreateMap<KlantModel, Klant>()
            //    .ForMember(dest => dest.Id, opt => opt.Ignore());
            //Mapper.CreateMap<QualityProcedureModel, QualityProcedure>()
            //    .ForMember(dest => dest.Id, opt => opt.Ignore());
            //Mapper.CreateMap<OorsprongModel, Oorsprong>()
            //    .ForMember(dest => dest.Id, opt => opt.Ignore());
            //Mapper.CreateMap<CaModel, Ca>()
            //    .ForMember(dest => dest.Id, opt => opt.Ignore());
            //Mapper.CreateMap<BestemmingModel, Bestemming>()
            //    .ForMember(dest => dest.Id, opt => opt.Ignore());
            //Mapper.CreateMap<LocatieModel, Locatie>()
            //    .ForMember(dest => dest.Id, opt => opt.Ignore());
            //Mapper.CreateMap<BetrokkeneModel, Betrokkene>()
            //    .ForMember(dest => dest.Id, opt => opt.Ignore());
            //Mapper.CreateMap<RpModel, Rp>()
            //    .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}