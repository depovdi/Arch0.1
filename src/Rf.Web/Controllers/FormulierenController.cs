using Rf.Domain;
using Rf.Repositories;
using Rf.Repositories.Interfaces;
using Rf.Web.Extensions;
using Rf.Web.Models;
using Rf.Web.ViewModel;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Castle.Core.Logging;

namespace Rf.Web.Controllers
{
    public class FormulierenController : Controller
    {
        public IRepository<Formulier> FormulierRepository { get; set; }
        public IRepository<Persoon> PersonenRepository { get; set; }
        public IRepository<Betrokkene> BetrokkenenRepository { get; set; }
        public IRepository<Voertuig> VoertuigenRepository { get; set; }
        public IRepository<Afdeling> AfdelingenRepository { get; set; }
        public IRepository<SoortKlacht> KlachtSoortenRepository { get; set; }
        public IRepository<Oorzaak> OorzakenRepository { get; set; }
        public IRepository<DetailCode> DetailCodesRepository { get; set; }
        public IRepository<Rp> RpRepository { get; set; }
        public IRepository<QualityProcedure> QualityProceduresRepository { get; set; }
        public IRepository<Unit> UnitRepository { get; set; }
        public IRepository<HoofdCode> HoofdCodesRepository { get; set; }
        public IRepository<Klant> KlantenRepository { get; set; }
        public IRepository<Oorsprong> OorsprongenRepository { get; set; }
        public IRepository<Bestemming> BestemmingenRepository { get; set; }
        public IRepository<Ca> CasRepository { get; set; }
        public IRepository<Locatie> LocatiesRepository { get; set; }

        public ILogger logger { get; set; }

        public ActionResult Index()
        {
            var formulieren = FormulierRepository.GetAll();
            var model = new FormulierIndexViewModel();
            model.Formulieren = formulieren.ToModel<FormulierModel>().ToList();
            model.Formulieren.ToList().ForEach(f => InstantiateNullObjects(f));

            return View(model);
        }

        [HttpGet]
        public ActionResult KlachtVanKlant(int id)
        {
            var resultRf = new Formulier();
            resultRf = FormulierRepository.GetFirstOrDefault(f => f.Id == id);
            var modelRf = resultRf.ToModel<FormulierModel>();
            var referenceData = GetReferenceDataModel();

            var model = new RapporteringsFormulierViewModel
            {
                RapporteringsFormulier = modelRf,
                ReferenceData = referenceData
            };

            MapSelections(model);

            return View(model);
        }

        [HttpPost]
        public ActionResult KlachtVanKlant(RapporteringsFormulierViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ReferenceData = GetReferenceDataModel();
                return View(model);
            }

            UpdateFormulier(model);

            return RedirectToAction("KlachtVanKlant", new { id = model.RapporteringsFormulier.Id });
        }

        [HttpGet]
        public ActionResult CreateKlachtVanKlant()
        {
            var referenceData = GetReferenceDataModel();
            var viewModel = new RapporteringsFormulierViewModel
            {
                ReferenceData = referenceData,
                RapporteringsFormulier = new FormulierModel { TypeRf = "KlachtVanKlant" }
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult CreateKlachtVanKlant(RapporteringsFormulierViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ReferenceData = GetReferenceDataModel();
                return View(model);
            }

            var createdRfId = CreateFormulier("KlachtVanKlant", model);

            return RedirectToAction("KlachtVanKlant", new { id = createdRfId });
        }

        [HttpGet]
        public ActionResult Onderscheiding(int id)
        {
            var resultRf = FormulierRepository.GetFirstOrDefault(f => f.Id == id);
            var referenceData = GetReferenceDataModel();

            var modelRf = resultRf.ToModel<FormulierModel>();

            var model = new RapporteringsFormulierViewModel
            {
                RapporteringsFormulier = modelRf,
                ReferenceData = referenceData
            };

            MapSelections(model);

            return View(model);
        }

        [HttpPost]
        public ActionResult Onderscheiding(RapporteringsFormulierViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ReferenceData = GetReferenceDataModel();
                return View(model);
            }

            UpdateFormulier(model);

            return RedirectToAction("Onderscheiding", new { id = model.RapporteringsFormulier.Id });
        }

        [HttpGet]
        public ActionResult CreateOnderscheiding()
        {
            var referenceData = GetReferenceDataModel();
            var viewModel = new RapporteringsFormulierViewModel
            {
                ReferenceData = referenceData,
                RapporteringsFormulier = new FormulierModel
                {
                    TypeRf = "Onderscheiding"
                }
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult CreateOnderscheiding(RapporteringsFormulierViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ReferenceData = GetReferenceDataModel();
                return View(model);
            }

            var createdRfId = CreateFormulier("Onderscheiding", model);

            return RedirectToAction("Onderscheiding", new { id = createdRfId });
        }

        [HttpGet]
        public ActionResult Voorstel(int id)
        {
            var resultRf = FormulierRepository.GetFirstOrDefault(f => f.Id == id);
            var referenceData = GetReferenceDataModel();

            var modelRf = resultRf.ToModel<FormulierModel>();

            var model = new RapporteringsFormulierViewModel
            {
                RapporteringsFormulier = modelRf,
                ReferenceData = referenceData
            };

            MapSelections(model);

            return View(model);
        }

        [HttpPost]
        public ActionResult Voorstel(RapporteringsFormulierViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ReferenceData = GetReferenceDataModel();
                return View(model);
            }

            UpdateFormulier(model);

            return RedirectToAction("Voorstel", new { id = model.RapporteringsFormulier.Id });
        }

        [HttpGet]
        public ActionResult CreateVoorstel()
        {
            var referenceData = GetReferenceDataModel();
            var viewModel = new RapporteringsFormulierViewModel
            {
                ReferenceData = referenceData,
                RapporteringsFormulier = new FormulierModel
                {
                    TypeRf = "Voorstel"
                }
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult CreateVoorstel(RapporteringsFormulierViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ReferenceData = GetReferenceDataModel();
                return View(model);
            }

            var createdRfId = CreateFormulier("Voorstel", model);

            return RedirectToAction("Voorstel", new { id = createdRfId });
        }

        public ActionResult Audit(int id)
        {
            var resultRf = FormulierRepository.GetFirstOrDefault(f => f.Id == id);
            var referenceData = GetReferenceDataModel();

            var modelRf = resultRf.ToModel<FormulierModel>();

            var model = new RapporteringsFormulierViewModel
            {
                RapporteringsFormulier = modelRf,
                ReferenceData = referenceData
            };

            MapSelections(model);

            return View(model);
        }

        [HttpPost]
        public ActionResult Audit(RapporteringsFormulierViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ReferenceData = GetReferenceDataModel();
                return View(model);
            }

            UpdateFormulier(model);

            return RedirectToAction("Audit", new { id = model.RapporteringsFormulier.Id });
        }

        [HttpGet]
        public ActionResult CreateAudit()
        {
            var referenceData = GetReferenceDataModel();
            var viewModel = new RapporteringsFormulierViewModel
            {
                ReferenceData = referenceData,
                RapporteringsFormulier = new FormulierModel
                {
                    TypeRf = "Audit"
                }
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult CreateAudit(RapporteringsFormulierViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ReferenceData = GetReferenceDataModel();
                return View(model);
            }

            var createdRfId = CreateFormulier("Audit", model);

            return RedirectToAction("Audit", new { id = createdRfId });
        }

        public ActionResult ArbeidsVerkeersOngeval(int id)
        {
            var resultRf = FormulierRepository.GetFirstOrDefault(f => f.Id == id);
            var referenceData = GetReferenceDataModel();

            var modelRf = resultRf.ToModel<FormulierModel>();

            var model = new RapporteringsFormulierViewModel
            {
                RapporteringsFormulier = modelRf,
                ReferenceData = referenceData
            };

            MapSelections(model);

            return View(model);
        }

        public ActionResult KlachtLeverancier(int id)
        {
            var resultRf = FormulierRepository.GetFirstOrDefault(f => f.Id == id);
            var modelRf = resultRf.ToModel<FormulierModel>();
            var referenceData = GetReferenceDataModel();

            var model = new RapporteringsFormulierViewModel
            {
                RapporteringsFormulier = modelRf,
                ReferenceData = referenceData
            };

            MapSelections(model);

            return View(model);
        }

        [HttpPost]
        public ActionResult KlachtLeverancier(RapporteringsFormulierViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ReferenceData = GetReferenceDataModel();
                return View(model);
            }

            UpdateFormulier(model);

            return RedirectToAction("KlachtLeverancier", new { id = model.RapporteringsFormulier.Id });
        }

        public ActionResult CreateKlachtLeverancier()
        {
            var referenceData = GetReferenceDataModel();

            var model = new RapporteringsFormulierViewModel
            {
                ReferenceData = referenceData,
                RapporteringsFormulier = new FormulierModel
                {
                    TypeRf = "KlachtLeverancier"
                }
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult CreateKlachtLeverancier(RapporteringsFormulierViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ReferenceData = GetReferenceDataModel();
                return View(model);
            }

            var createdRfId = CreateFormulier("KlachtLeverancier", model);

            return RedirectToAction("KlachtLeverancier", new { id = createdRfId });
        }

        [HttpGet]
        public ActionResult NietConformiteit(int id)
        {
            var resultRf = FormulierRepository.GetFirstOrDefault(f => f.Id == id);
            var referenceData = GetReferenceDataModel();

            var modelRf = resultRf.ToModel<FormulierModel>();

            var model = new RapporteringsFormulierViewModel
            {
                RapporteringsFormulier = modelRf,
                ReferenceData = referenceData
            };

            MapSelections(model);

            return View(model);
        }

        [HttpPost]
        public ActionResult NietConformiteit(RapporteringsFormulierViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ReferenceData = GetReferenceDataModel();
                return View(model);
            }

            UpdateFormulier(model);

            return RedirectToAction("NietConformiteit", new { id = model.RapporteringsFormulier.Id });
        }

        [HttpGet]
        public ActionResult CreateNietConformiteit()
        {
            var referenceData = GetReferenceDataModel();
            var viewModel = new RapporteringsFormulierViewModel
            {
                ReferenceData = referenceData,
                RapporteringsFormulier = new FormulierModel
                {
                    TypeRf = "NietConformiteit"
                }
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult CreateNietConformiteit(RapporteringsFormulierViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ReferenceData = GetReferenceDataModel();
                return View(model);
            }

            var createdRfId = CreateFormulier("NietConformiteit", model);

            return RedirectToAction("NietConformiteit", new { id = createdRfId });
        }

        public ActionResult Ongeval(int id)
        {
            var resultRf = FormulierRepository.GetFirstOrDefault(f => f.Id == id);
            var modelRf = resultRf.ToModel<FormulierModel>();
            var referenceData = GetReferenceDataModel();

            var model = new RapporteringsFormulierViewModel
            {
                RapporteringsFormulier = modelRf,
                ReferenceData = referenceData
            };

            MapSelections(model);

            return View(model);
        }

        [HttpPost]
        public ActionResult Ongeval(RapporteringsFormulierViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ReferenceData = GetReferenceDataModel();
                return View(model);
            }

            UpdateFormulier(model);

            return RedirectToAction("Ongeval", new { id = model.RapporteringsFormulier.Id });
        }

        [HttpGet]
        public ActionResult CreateOngeval()
        {
            var referenceData = GetReferenceDataModel();
            var viewModel = new RapporteringsFormulierViewModel
            {
                ReferenceData = referenceData,
                RapporteringsFormulier = new FormulierModel()
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult CreateOngeval(RapporteringsFormulierViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ReferenceData = GetReferenceDataModel();
                return View(model);
            }

            var createdRfId = CreateFormulier("Ongeval", model);

            return RedirectToAction("Ongeval", new { id = createdRfId });
        }

        private int CreateFormulier(string type, RapporteringsFormulierViewModel model)
        {
            var formulier = model.RapporteringsFormulier.ToModel<Formulier>();
            formulier.TypeRf = type;
            formulier.CreatieDatum = DateTime.Now;
            ApplyChanges(model, formulier);

            var createdRf = FormulierRepository.Add(formulier);
            FormulierRepository.SaveChanges();

            logger.Info("User x created report form id " + createdRf.Id);

            return createdRf.Id;
        }

        public void UpdateFormulier(RapporteringsFormulierViewModel model)
        {
            var originalRf = FormulierRepository.GetFirstOrDefault(f => f.Id == model.RapporteringsFormulier.Id);
            if (originalRf == null)
            {
                logger.Warn("Action: Update / Result: Id not found " + model.RapporteringsFormulier.Id);
                throw new HttpException(404, "Het gevraagde rapport werd niet gevonden");
            }
            logger.Info("User x updated report form id " + model.RapporteringsFormulier.Id);
            
            //originalRf = model.RapporteringsFormulier.ToModel<Formulier>(originalRf);


            ApplyChanges(model, originalRf);

            FormulierRepository.Update(originalRf);
            FormulierRepository.SaveChanges();
        }

        private static void MapSelections(RapporteringsFormulierViewModel model)
        {
            InstantiateNullObjects(model.RapporteringsFormulier);

            model.SelectedOntvangerId = model.RapporteringsFormulier.Ontvanger.Id;
            model.SelectedOntvangerQLId = model.RapporteringsFormulier.OntvangerQL.Id;
            model.SelectedOpstellerId = model.RapporteringsFormulier.Opsteller.Id;
            model.SelectedVoertuigId = model.RapporteringsFormulier.Voertuig.Id;
            model.SelectedKlachtSoortId = model.RapporteringsFormulier.Soortklacht.Id;
            model.SelectedDetailCodeId = model.RapporteringsFormulier.DetailCode.Id;
            model.SelectedHoofdCodeId = model.RapporteringsFormulier.HoofdCode.Id;
            model.SelectedQualityProcedureId = model.RapporteringsFormulier.QualityProcedure.Id;
            model.SelectedUnitId = model.RapporteringsFormulier.Unit.Id;
            model.SelectedAfdelingId = model.RapporteringsFormulier.Afdeling.Id;
            model.SelectedRpId = model.RapporteringsFormulier.Rp.Id;

            model.SelectedKlantenIds = model.RapporteringsFormulier.Klanten.Select(k => k.Id).ToArray();
            model.SelectedOorzaakIds = model.RapporteringsFormulier.Oorzaken.Select(o => o.Id).ToArray();
            model.SelectedOorsprongIds = model.RapporteringsFormulier.Oorsprongen.Select(o => o.Id).ToArray();
            model.SelectedCaIds = model.RapporteringsFormulier.Cas.Select(c => c.Id).ToArray();
            model.SelectedBestemmingIds = model.RapporteringsFormulier.Bestemmingen.Select(b => b.Id).ToArray();
            model.SelectedLocatieIds = model.RapporteringsFormulier.Locaties.Select(l => l.Id).ToArray();
            model.SelectedBetrokkeneIds = model.RapporteringsFormulier.Betrokkenen.Select(b => b.Id).ToArray();
        }

        private static void InstantiateNullObjects(FormulierModel model)
        {
            if (model.Ontvanger == null)
            {
                model.Ontvanger = new PersoonModel();
                model.Ontvanger.Afdeling = new AfdelingModel();
            }

            if (model.Opsteller == null)
            {
                model.Opsteller = new PersoonModel();
                model.Opsteller.Afdeling = new AfdelingModel();
            }

            if (model.OntvangerQL == null)
            {
                model.OntvangerQL = new PersoonModel();
                model.OntvangerQL.Afdeling = new AfdelingModel();
            }

            if (model.Voertuig == null)
                model.Voertuig = new VoertuigModel();

            if (model.Soortklacht == null)
                model.Soortklacht = new SoortKlachtModel();

            if (model.DetailCode == null)
                model.DetailCode = new DetailCodeModel();

            if (model.HoofdCode == null)
                model.HoofdCode = new HoofdCodeModel();

            if (model.QualityProcedure == null)
                model.QualityProcedure = new QualityProcedureModel();

            if (model.Unit == null)
                model.Unit = new UnitModel();

            if (model.Afdeling == null)
                model.Afdeling = new AfdelingModel();

            if (model.Rp == null)
                model.Rp = new RpModel();
        }

        private void ApplyChanges(RapporteringsFormulierViewModel model, Formulier formulier)
        {
            var opstellerId = model.SelectedOpstellerId;
            var ontvangerId = model.SelectedOntvangerId.GetValueOrDefault(0);
            var ontvangerQlId = model.SelectedOntvangerQLId.GetValueOrDefault(0);
            var afdelingId = model.SelectedAfdelingId.GetValueOrDefault(0);
            var voertuigId = model.SelectedVoertuigId.GetValueOrDefault(0);
            var klachtSoortId = model.SelectedKlachtSoortId.GetValueOrDefault(0);
            var detailCodeId = model.SelectedDetailCodeId.GetValueOrDefault(0);
            var rpId = model.SelectedRpId.GetValueOrDefault(0);
            var qualityProcedureId = model.SelectedQualityProcedureId.GetValueOrDefault(0);
            var UnitId = model.SelectedUnitId.GetValueOrDefault(0);
            var hoofdCodeId = model.SelectedHoofdCodeId.GetValueOrDefault(0);

            formulier.Afdeling = AfdelingenRepository.GetFirstOrDefault(a => a.Id == afdelingId);
            formulier.Voertuig = VoertuigenRepository.GetFirstOrDefault(v => v.Id == voertuigId);
            formulier.Soortklacht = KlachtSoortenRepository.GetFirstOrDefault(ks => ks.Id == klachtSoortId);
            formulier.Opsteller = PersonenRepository.GetFirstOrDefault(p => p.Id == opstellerId);
            formulier.Ontvanger = PersonenRepository.GetFirstOrDefault(p => p.Id == ontvangerId);
            formulier.OntvangerQL = PersonenRepository.GetFirstOrDefault(p => p.Id == ontvangerQlId);
            formulier.DetailCode = DetailCodesRepository.GetFirstOrDefault(dc => dc.Id == detailCodeId);
            formulier.Rp = RpRepository.GetFirstOrDefault(rp => rp.Id == rpId);
            formulier.QualityProcedure = QualityProceduresRepository.GetFirstOrDefault(qp => qp.Id == qualityProcedureId);
            formulier.Unit = UnitRepository.GetFirstOrDefault(u => u.Id == UnitId);
            formulier.HoofdCode = HoofdCodesRepository.GetFirstOrDefault(hc => hc.Id == hoofdCodeId);
            formulier.Omschrijving = model.RapporteringsFormulier.Omschrijving;
            formulier.Gevolg = model.RapporteringsFormulier.Gevolg;
            formulier.Referentie = model.RapporteringsFormulier.Referentie;
            formulier.KlachtGeuitDoor = model.RapporteringsFormulier.KlachtGeuitDoor;
            formulier.OorzaakOmschrijving = model.RapporteringsFormulier.OorzaakOmschrijving;
            formulier.Oplossing = model.RapporteringsFormulier.Oplossing;
            formulier.Leverancier = model.RapporteringsFormulier.Leverancier;
            formulier.ContainerNummer = model.RapporteringsFormulier.ContainerNummer;
            formulier.TruckNummer = model.RapporteringsFormulier.TruckNummer;
            formulier.Batch = model.RapporteringsFormulier.Batch;
            formulier.ExceptieRapporteringsNummer = model.RapporteringsFormulier.ExceptieRapporteringsNummer;
            formulier.Kost = model.RapporteringsFormulier.Kost;
            formulier.FactuurNummer = model.RapporteringsFormulier.FactuurNummer;
            formulier.ClaimNummer = model.RapporteringsFormulier.ClaimNummer;
            formulier.AkmOmschrijving = model.RapporteringsFormulier.AkmOmschrijving;
            formulier.Dossiernummers = model.RapporteringsFormulier.Dossiernummers;
            formulier.AantalUnits = model.RapporteringsFormulier.AantalUnits;
            formulier.OorzaakAchterliggend = model.RapporteringsFormulier.OorzaakAchterliggend;
            formulier.ControleReferentieOntvanger = model.RapporteringsFormulier.ControleReferentieOntvanger;
            formulier.ControleReferentieOpsteller = model.RapporteringsFormulier.ControleReferentieOpsteller;
            formulier.AoNummer = model.RapporteringsFormulier.AoNummer;
            formulier.Opmerking = model.RapporteringsFormulier.Opmerking;
            formulier.QualityDocumentNaam = model.RapporteringsFormulier.QualityDocumentNaam;
            formulier.OplossingsDatum = model.RapporteringsFormulier.OplossingsDatum;
            formulier.OplossingsDatumQL = model.RapporteringsFormulier.OplossingsDatumQL;
            formulier.VaststellingsDatum = model.RapporteringsFormulier.VaststellingsDatum;

            EnumBooleanModel communicatieKlantOpsteller = model.RapporteringsFormulier.CommunicatieKlantOpsteller;
            switch (communicatieKlantOpsteller)
            {
                case EnumBooleanModel.NoSelection:
                    formulier.CommunicatieKlantOpsteller = EnumBoolean.NoSelection;
                    break;
                case EnumBooleanModel.No:
                    formulier.CommunicatieKlantOpsteller = EnumBoolean.No;
                    break;
                case EnumBooleanModel.Yes:
                    formulier.CommunicatieKlantOpsteller = EnumBoolean.Yes;
                    break;
                case EnumBooleanModel.Unknown:
                    formulier.CommunicatieKlantOpsteller = EnumBoolean.Unknown;
                    break;
            }

            EnumBooleanModel isQualityDocumentVolledig = model.RapporteringsFormulier.IsQualityDocumentVolledig;
            switch (isQualityDocumentVolledig)
            {
                case EnumBooleanModel.NoSelection:
                    formulier.IsQualityDocumentVolledig = EnumBoolean.NoSelection;
                    break;
                case EnumBooleanModel.No:
                    formulier.IsQualityDocumentVolledig = EnumBoolean.No;
                    break;
                case EnumBooleanModel.Yes:
                    formulier.IsQualityDocumentVolledig = EnumBoolean.Yes;
                    break;
                case EnumBooleanModel.Unknown:
                    formulier.IsQualityDocumentVolledig = EnumBoolean.Unknown;
                    break;
            }

            EnumBooleanModel systematischeControleOntvanger = model.RapporteringsFormulier.SystematischeControleOntvanger;
            switch (systematischeControleOntvanger)
            {
                case EnumBooleanModel.NoSelection:
                    formulier.SystematischeControleOntvanger = EnumBoolean.NoSelection;
                    break;
                case EnumBooleanModel.No:
                    formulier.SystematischeControleOntvanger = EnumBoolean.No;
                    break;
                case EnumBooleanModel.Yes:
                    formulier.SystematischeControleOntvanger = EnumBoolean.Yes;
                    break;
                case EnumBooleanModel.Unknown:
                    formulier.SystematischeControleOntvanger = EnumBoolean.Unknown;
                    break;
            }

            EnumBooleanModel systematischeControleOpsteller = model.RapporteringsFormulier.SystematischeControleOpsteller;
            switch (systematischeControleOpsteller)
            {
                case EnumBooleanModel.NoSelection:
                    formulier.SystematischeControleOpsteller = EnumBoolean.NoSelection;
                    break;
                case EnumBooleanModel.No:
                    formulier.SystematischeControleOpsteller = EnumBoolean.No;
                    break;
                case EnumBooleanModel.Yes:
                    formulier.SystematischeControleOpsteller = EnumBoolean.Yes;
                    break;
                case EnumBooleanModel.Unknown:
                    formulier.SystematischeControleOpsteller = EnumBoolean.Unknown;
                    break;
            }

            EnumBooleanModel doorrekenenKost = model.RapporteringsFormulier.DoorrekenenKost;
            switch (doorrekenenKost)
            {
                case EnumBooleanModel.NoSelection:
                    formulier.DoorrekenenKost = EnumBoolean.NoSelection;
                    break;
                case EnumBooleanModel.No:
                    formulier.DoorrekenenKost = EnumBoolean.No;
                    break;
                case EnumBooleanModel.Yes:
                    formulier.DoorrekenenKost = EnumBoolean.Yes;
                    break;
                case EnumBooleanModel.Unknown:
                    formulier.DoorrekenenKost = EnumBoolean.Unknown;
                    break;
            }

            EnumBooleanModel isNieuwQualityDocumentNodig = model.RapporteringsFormulier.IsNieuwQualityDocumentNodig;
            switch (isNieuwQualityDocumentNodig)
            {
                case EnumBooleanModel.NoSelection:
                    formulier.IsNieuwQualityDocumentNodig = EnumBoolean.NoSelection;
                    break;
                case EnumBooleanModel.No:
                    formulier.IsNieuwQualityDocumentNodig = EnumBoolean.No;
                    break;
                case EnumBooleanModel.Yes:
                    formulier.IsNieuwQualityDocumentNodig = EnumBoolean.Yes;
                    break;
                case EnumBooleanModel.Unknown:
                    formulier.IsNieuwQualityDocumentNodig = EnumBoolean.Unknown;
                    break;
            }

            EnumBooleanModel isQualityDocumentBeschreven = model.RapporteringsFormulier.IsQualityDocumentBeschreven;
            switch (isQualityDocumentBeschreven)
            {
                case EnumBooleanModel.NoSelection:
                    formulier.IsQualityDocumentBeschreven = EnumBoolean.NoSelection;
                    break;
                case EnumBooleanModel.No:
                    formulier.IsQualityDocumentBeschreven = EnumBoolean.No;
                    break;
                case EnumBooleanModel.Yes:
                    formulier.IsQualityDocumentBeschreven = EnumBoolean.Yes;
                    break;
                case EnumBooleanModel.Unknown:
                    formulier.IsQualityDocumentBeschreven = EnumBoolean.Unknown;
                    break;
            }

            EnumBooleanModel isSystematischeControleVolledig = model.RapporteringsFormulier.IsSystematischeControleVolledig;
            switch (isSystematischeControleVolledig)
            {
                case EnumBooleanModel.NoSelection:
                    formulier.IsSystematischeControleVolledig = EnumBoolean.NoSelection;
                    break;
                case EnumBooleanModel.No:
                    formulier.IsSystematischeControleVolledig = EnumBoolean.No;
                    break;
                case EnumBooleanModel.Yes:
                    formulier.IsSystematischeControleVolledig = EnumBoolean.Yes;
                    break;
                case EnumBooleanModel.Unknown:
                    formulier.IsSystematischeControleVolledig = EnumBoolean.Unknown;
                    break;
            }

            EnumBooleanModel beveiligingsIncident = model.RapporteringsFormulier.BeveiligingsIncident;
            switch (beveiligingsIncident)
            {
                case EnumBooleanModel.NoSelection:
                    formulier.BeveiligingsIncident = EnumBoolean.NoSelection;
                    break;
                case EnumBooleanModel.No:
                    formulier.BeveiligingsIncident = EnumBoolean.No;
                    break;
                case EnumBooleanModel.Yes:
                    formulier.BeveiligingsIncident = EnumBoolean.Yes;
                    break;
                case EnumBooleanModel.Unknown:
                    formulier.BeveiligingsIncident = EnumBoolean.Unknown;
                    break;
            }

            EnumBooleanModel communicatieKlantOntvanger = model.RapporteringsFormulier.CommunicatieKlantOntvanger;
            switch (communicatieKlantOntvanger)
            {
                case EnumBooleanModel.NoSelection:
                    formulier.CommunicatieKlantOntvanger = EnumBoolean.NoSelection;
                    break;
                case EnumBooleanModel.No:
                    formulier.CommunicatieKlantOntvanger = EnumBoolean.No;
                    break;
                case EnumBooleanModel.Yes:
                    formulier.CommunicatieKlantOntvanger = EnumBoolean.Yes;
                    break;
                case EnumBooleanModel.Unknown:
                    formulier.CommunicatieKlantOntvanger = EnumBoolean.Unknown;
                    break;
            }

            EnumBooleanModel nieuweControle = model.RapporteringsFormulier.NieuweControle;
            switch (nieuweControle)
            {
                case EnumBooleanModel.NoSelection:
                    formulier.NieuweControle = EnumBoolean.NoSelection;
                    break;
                case EnumBooleanModel.No:
                    formulier.NieuweControle = EnumBoolean.No;
                    break;
                case EnumBooleanModel.Yes:
                    formulier.NieuweControle = EnumBoolean.Yes;
                    break;
                case EnumBooleanModel.Unknown:
                    formulier.NieuweControle = EnumBoolean.Unknown;
                    break;
            }

            EnumBooleanModel voorstelAanvaard = model.RapporteringsFormulier.VoorstelAanvaard;
            switch (voorstelAanvaard)
            {
                case EnumBooleanModel.NoSelection:
                    formulier.VoorstelAanvaard = EnumBoolean.NoSelection;
                    break;
                case EnumBooleanModel.No:
                    formulier.VoorstelAanvaard = EnumBoolean.No;
                    break;
                case EnumBooleanModel.Yes:
                    formulier.VoorstelAanvaard = EnumBoolean.Yes;
                    break;
                case EnumBooleanModel.Unknown:
                    formulier.VoorstelAanvaard = EnumBoolean.Unknown;
                    break;
            }

            EnumBooleanModel opnemenCa = model.RapporteringsFormulier.OpnemenCapa;
            switch(opnemenCa)
            {
                case EnumBooleanModel.NoSelection:
                    formulier.OpnemenCapa = EnumBoolean.NoSelection;
                    break;
                case EnumBooleanModel.No:
                    formulier.OpnemenCapa = EnumBoolean.No;
                    break;
                case EnumBooleanModel.Yes:
                    formulier.OpnemenCapa = EnumBoolean.Yes;
                    break;
                case EnumBooleanModel.Unknown:
                    formulier.OpnemenCapa = EnumBoolean.Unknown;
                    break;
            }

            EnumStatusRfModel statusRf = model.RapporteringsFormulier.StatusRfEnum;
            switch (statusRf)
            {
                case EnumStatusRfModel.Nieuw:
                    formulier.StatusRfEnum = EnumStatusRf.Nieuw;
                    break;
                case EnumStatusRfModel.Geregistreerd:
                    formulier.StatusRfEnum = EnumStatusRf.Geregistreerd;
                    break;
                case EnumStatusRfModel.Beantwoord:
                    formulier.StatusRfEnum = EnumStatusRf.Beantwoord;
                    break;
                case EnumStatusRfModel.Afgesloten:
                    formulier.StatusRfEnum = EnumStatusRf.Afgesloten;
                    break;
            }

            EnumAuditTypeModel auditType = model.RapporteringsFormulier.AuditTypeEnum;
            switch(auditType)
            {
                case EnumAuditTypeModel.NietsGeselecteerd:
                    formulier.AuditTypeEnum = EnumAuditType.NietsGeselecteerd;
                    break;
                case EnumAuditTypeModel.ExterneAudit:
                    formulier.AuditTypeEnum = EnumAuditType.ExterneAudit;
                    break;
                case EnumAuditTypeModel.InterneAudit:
                    formulier.AuditTypeEnum = EnumAuditType.InterneAudit;
                    break;
            }

            EnumDossierTypeModel dossierType = model.RapporteringsFormulier.DossierTypeEnum;
            switch (dossierType)
            {
                case EnumDossierTypeModel.NietsGeselecteerd:
                    formulier.DossierTypeEnum = EnumDossierType.NietsGeselecteerd;
                    break;
                case EnumDossierTypeModel.Import:
                    formulier.DossierTypeEnum = EnumDossierType.Import;
                    break;
                case EnumDossierTypeModel.Export:
                    formulier.DossierTypeEnum = EnumDossierType.Export;
                    break;
                case EnumDossierTypeModel.Andere:
                    formulier.DossierTypeEnum = EnumDossierType.Andere;
                    break;
            }

            EnumOngevalTypeModel ongevalType = model.RapporteringsFormulier.OngevalTypeEnum;
            switch (ongevalType)
            {
                case EnumOngevalTypeModel.NietsGeselecteerd:
                    formulier.OngevalTypeEnum = EnumOngevalType.NietsGeselecteerd;
                    break;
                case EnumOngevalTypeModel.Arbeidsongeval:
                    formulier.OngevalTypeEnum = EnumOngevalType.Arbeidsongeval;
                    break;
                case EnumOngevalTypeModel.Verkeersongeval:
                    formulier.OngevalTypeEnum = EnumOngevalType.Verkeersongeval;
                    break;
            }

            if (model.RapporteringsFormulier.StatusRfEnum == EnumStatusRfModel.Afgesloten)
            {
                formulier.Afsluiten();
            }

            var betrokkenen = BetrokkenenRepository.GetAll(b => model.SelectedBetrokkeneIds.Contains(b.Id));
            formulier.Betrokkenen.Clear();

            foreach (var betrokkene in betrokkenen)
            {
                formulier.Betrokkenen.Add(betrokkene);
            }

            var klantent = KlantenRepository.GetAll(k => model.SelectedKlantenIds.Contains(k.Id));
            formulier.Klanten.Clear();

            foreach (var klant in klantent)
            {
                formulier.Klanten.Add(klant);
            }

            var oorsprongen = OorsprongenRepository.GetAll(o => model.SelectedOorsprongIds.Contains(o.Id));
            formulier.Oorsprongen.Clear();

            foreach (var oorsprong in oorsprongen)
            {
                formulier.Oorsprongen.Add(oorsprong);
            }

            var bestemmingen = BestemmingenRepository.GetAll(b => model.SelectedBestemmingIds.Contains(b.Id));
            formulier.Bestemmingen.Clear();

            foreach (var bestemming in bestemmingen)
            {
                formulier.Bestemmingen.Add(bestemming);
            }

            var locaties = LocatiesRepository.GetAll(l => model.SelectedLocatieIds.Contains(l.Id));
            formulier.Locaties.Clear();

            foreach (var locatie in locaties)
            {
                formulier.Locaties.Add(locatie);
            }

            var oorzaken = OorzakenRepository.GetAll(o => model.SelectedOorzaakIds.Contains(o.Id));
            formulier.Oorzaken.Clear();

            foreach (var oorzaak in oorzaken)
            {
                formulier.Oorzaken.Add(oorzaak);
            }

            var cas = CasRepository.GetAll(c => model.SelectedCaIds.Contains(c.Id));
            formulier.Cas.Clear();

            foreach (var ca in cas)
            {
                formulier.Cas.Add(ca);
            }
        }

        private ReferenceDataModel GetReferenceDataModel()
        {
            var resultPersoon = PersonenRepository.GetAllOrdered(p => p.Naam);
            var resultVoertuig = VoertuigenRepository.GetAllOrdered(v => v.NummerPlaat);
            var resultSoortKlacht = KlachtSoortenRepository.GetAllOrdered(k => k.Soort);
            var resultOorzaak = OorzakenRepository.GetAllOrdered(o => o.Code);
            var resultDetailCode = DetailCodesRepository.GetAllOrdered(d => d.Code);
            var resultHoofdCode = HoofdCodesRepository.GetAllOrdered(h => h.Code);
            var resultKlant = KlantenRepository.GetAllOrdered(k => k.Naam);
            var resultQualityProcedure = QualityProceduresRepository.GetAllOrdered(q => q.Naam);
            var resultUnit = UnitRepository.GetAllOrdered(u => u.Naam);
            var resultOorsprong = OorsprongenRepository.GetAllOrdered(o => o.Naam);
            var resultAfdeling = AfdelingenRepository.GetAllOrdered(a => a.Naam);
            var resultCa = CasRepository.GetAllOrdered(c => c.Code);
            var resultBestemming = BestemmingenRepository.GetAllOrdered(b => b.Naam);
            var resultLocatie = LocatiesRepository.GetAllOrdered(l => l.Naam);
            var resultBetrokkene = BetrokkenenRepository.GetAllOrdered(b => b.Naam);
            var resultRp = RpRepository.GetAllOrdered(r => r.Naam);
            var resultFormulierAfwerkingsDatum = RpRepository.GetAllOrdered(r => r.Naam);

            var modelPersoon = resultPersoon.ToModel<PersoonModel>().ToList();
            var modelVoertuig = resultVoertuig.ToModel<VoertuigModel>().ToList();
            var modelKlachtSoort = resultSoortKlacht.ToModel<SoortKlachtModel>().ToList();
            var modelOorzaak = resultOorzaak.ToModel<OorzaakModel>().ToList();
            var modelDetailCode = resultDetailCode.ToModel<DetailCodeModel>().ToList();
            var modelHoofdCode = resultHoofdCode.ToModel<HoofdCodeModel>().ToList();
            var modelKlant = resultKlant.ToModel<KlantModel>().ToList();
            var modelQualityProcedure = resultQualityProcedure.ToModel<QualityProcedureModel>().ToList();
            var modelUnit = resultUnit.ToModel<UnitModel>().ToList();
            var modelAfdeling = resultAfdeling.ToModel<AfdelingModel>().ToList();
            var modelOorsprong = resultOorsprong.ToModel<OorsprongModel>().ToList();
            var modelCa = resultCa.ToModel<CaModel>().ToList();
            var modelBestemming = resultBestemming.ToModel<BestemmingModel>().ToList();
            var modelLocatie = resultLocatie.ToModel<LocatieModel>().ToList();
            var modelBetrokkene = resultBetrokkene.ToModel<BetrokkeneModel>().ToList();
            var modelRp = resultRp.ToModel<RpModel>().ToList();

            return new ReferenceDataModel
            {
                Personen = modelPersoon,
                Voertuigen = modelVoertuig,
                KlachtSoorten = modelKlachtSoort,
                Oorzaken = modelOorzaak,
                DetailCodes = modelDetailCode,
                HoofdCodes = modelHoofdCode,
                Klanten = modelKlant,
                QualityProcedures = modelQualityProcedure,
                Units = modelUnit,
                Afdelingen = modelAfdeling,
                Oorsprongen = modelOorsprong,
                Cas = modelCa,
                Bestemmingen = modelBestemming,
                Locaties = modelLocatie,
                Betrokkenen = modelBetrokkene,
                Rps = modelRp
            };
        }
    }
}
