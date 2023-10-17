using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sinan.Data;
using Sinan.Models;
using Sinan.ViewModels;

namespace Sinan.Controllers
{
    public class PacientesController : Controller
    {
        private readonly AppDBcontext _context;

        public PacientesController(AppDBcontext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string dataNascimento, string nome, string nomeMae)
        {
            // Consulta o banco de dados usando os parâmetros de filtragem
            var pacientes = _context.Pacientes.AsQueryable();

            if (!string.IsNullOrEmpty(dataNascimento))
            {
                var dataNascVal = DateOnly.FromDateTime(DateTime.Now);
                if (DateOnly.TryParse(dataNascimento, out dataNascVal))
                {
                    pacientes = pacientes.Where(p => p.birthdate == dataNascVal);
                }
            }

            if (!string.IsNullOrEmpty(nome))
            {
                pacientes = pacientes.Where(p => p.name.Contains(nome));
            }

            if (!string.IsNullOrEmpty(nomeMae))
            {
                pacientes = pacientes.Where(p => p.momname.Contains(nomeMae));
            }

            // Execute a consulta e retorne os resultados para a exibição
            var pacientesFiltrados = await pacientes.ToListAsync();

            return View(pacientesFiltrados);
        }

        public async Task<IActionResult> Details(long Idpacient)
        {
            var paciente = await _context.Pacientes.FirstOrDefaultAsync(m => m.Idpacient == Idpacient);
            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Paciente paciente)
        {
            // Verifique se já existe um paciente com o mesmo CPF no banco de dados
            if (!_context.Pacientes.Any(p => p.cpf == paciente.cpf))
            {
                // Se não existir, adicione o novo paciente
                _context.Add(paciente);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("Duplicatascpf", "Este CPF já está gravado em nossa base de dados");
                return View(paciente);
            }
        }

        public async Task<IActionResult> Edit(long Idpacient)
        {
            var paciente = await _context.Pacientes.FindAsync(Idpacient);
            if (paciente == null)
                return NotFound();

            return View(paciente);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Paciente paciente)
        {
            if (!_context.Pacientes.Any(p => p.cpf == paciente.cpf && p.Idpacient != paciente.Idpacient))
            {
                _context.Update(paciente);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(paciente);
        }

        public async Task<IActionResult> Delete(long Idpacient)
        {
            var paciente = await _context.Pacientes.FirstOrDefaultAsync(m => m.Idpacient == Idpacient);
            if (paciente == null)
                return NotFound();

            return View(paciente);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(long Idpacient)
        {
            var paciente = await _context.Pacientes.FindAsync(Idpacient);
            if (paciente != null)
            {
                _context.Pacientes.Remove(paciente);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Export(long Idpacient, long Idnotify)
        {
            var pacient = await _context.Pacientes.FindAsync(Idpacient);
            var notify = await _context.Notificacoes.FindAsync(Idnotify);

            var viewModel = new Exports
            {
                Idpacient = pacient.Idpacient,
                name = pacient.name,
                birthdate = pacient.birthdate,
                schooling = pacient.schooling,
                suscard = pacient.suscard,
                cpf = pacient.cpf,
                bloodType = pacient.bloodType,
                momname = pacient.momname,
                ancestry = pacient.ancestry,
                gender = pacient.gender,
                height = pacient.height,
                weight = pacient.weight,
                uf = pacient.uf,
                municipality = pacient.municipality,
                pneighborhood = pacient.pneighborhood,
                address = pacient.address,
                number = pacient.number,
                complement = pacient.complement,
                phone = pacient.phone,
                cep = pacient.cep,
                zone = pacient.zone,
                Idnotify = notify.Idnotify,
                Agravo = notify.Agravo,
                datenotify = notify.datenotify,
                us = notify.us,
                datesynptoms = notify.datesynptoms,
                pregnant = notify.pregnant,
                dateinv = notify.dateinv,
                occupation = notify.occupation,
                fever = notify.fever,
                myalgia = notify.myalgia,
                headache = notify.headache,
                rash = notify.rash,
                vomit = notify.vomit,
                nausea = notify.nausea,
                backPain = notify.backPain,
                conjunctivitis = notify.conjunctivitis,
                arthritis = notify.arthritis,
                severeArthralgia = notify.severeArthralgia,
                petechiae = notify.petechiae,
                leukopenia = notify.leukopenia,
                tieProof = notify.tieProof,
                retroorbitalPain = notify.retroorbitalPain,
                diabetes = notify.diabetes,
                hDiseases = notify.hDiseases,
                liverDiseases = notify.liverDiseases,
                ckDisease = notify.ckDisease,
                hypertension = notify.hypertension,
                paDisease = notify.paDisease,
                aiDisease = notify.aiDisease,
                cfsCollecting = notify.cfsCollecting,
                cfsStatus = notify.cfsStatus,
                cssCollecting = notify.cssCollecting,
                cssStatus = notify.cssStatus,
                prntCollecting = notify.prntCollecting,
                prntStatus = notify.prntStatus,
                dsCollecting = notify.dsCollecting,
                dsStatus = notify.dsStatus,
                ns1Collecting = notify.ns1Collecting,
                ns1Status = notify.ns1Status,
                insCollecting = notify.insCollecting,
                insStatus = notify.insStatus,
                rtpcrCollecting = notify.rtpcrCollecting,
                rtpcrStatus = notify.rtpcrStatus,
                serotype = notify.serotype,
                srtSelect = notify.srtSelect,
                pHypotension = notify.pHypotension,
                plateletsFall = notify.plateletsFall,
                pVomiting = notify.pVomiting,
                scaPain = notify.scaPain,
                loIrritability = notify.loIrritability,
                moBleeding = notify.moBleeding,
                piHematocrit = notify.piHematocrit,
                alarmingDate = notify.alarmingDate,
                hge2cm = notify.hge2cm,
                iLiquids = notify.iLiquids,
                wuPulse = notify.wuPulse,
                convergentbp = notify.convergentbp,
                crTime = notify.crTime,
                afrInsuficiency = notify.afrInsuficiency,
                tachycardia = notify.tachycardia,
                cExtremities = notify.cExtremities,
                lsHypotension = notify.lsHypotension,
                hematemesis = notify.hematemesis,
                melena = notify.melena,
                bMetrorrhagia = notify.bMetrorrhagia,
                cnsBleeding = notify.cnsBleeding,
                astalt = notify.astalt,
                myocarditis = notify.myocarditis,
                aConciousness = notify.aConciousness,
                aOrgans = notify.aOrgans,
                organName = notify.organName,
                sinDateinit = notify.sinDateinit,
                patientClass = notify.patientClass,
                recentTravel = notify.recentTravel,
                travelPlace = notify.travelPlace,
                goTravel = notify.goTravel,
                backTravel = notify.backTravel,
                visitor = notify.visitor,
                eeArea = notify.eeArea,
                areaKnlg = notify.areaKnlg,
                pMedication = notify.pMedication,
                medName = notify.medName,
                pEncaminhation = notify.pEncaminhation,
                ePlace = notify.ePlace,
                motive = notify.motive,
                iName = notify.iName,
                iFunction = notify.iFunction,
                hospitalization = notify.hospitalization,
                hospDate = notify.hospDate,
                hospUF = notify.hospUF,
                hospMun = notify.hospMun,
                hospName = notify.hospName,
                caseMun = notify.caseMun,
                munUf = notify.munUf,
                munCon = notify.munCon,
                neighborhood = notify.neighborhood,
                conClass = notify.conClass,
                criterion = notify.criterion,
                caseEvo = notify.caseEvo,
                closingDate = notify.closingDate
            };

            return View(viewModel);
        }

    }
}
