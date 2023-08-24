using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sinan.Data;
using Sinan.Models;

namespace Sinan.Controllers
{
    public class NotificacoesController : Controller
    {
        private readonly AppDBcontext _context;

        public NotificacoesController(AppDBcontext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var notificacoes = await _context.Notificacoes.ToListAsync();

            return View(notificacoes);
        }

        public async Task<IActionResult> Details(long Idnotify)
        {
            var notificacao = await _context.Notificacoes.FirstOrDefaultAsync(m => m.Idnotify == Idnotify);
            if (notificacao == null)
            {
                return NotFound();
            }

            return View(notificacao);
        }

        public IActionResult Create(long Idpacient)
        {
            ViewBag.Idpacient = Idpacient;
            return View();
        }

        public bool Duplicate (int Idpacient)
        {
            DateTime difference = DateTime.Now.AddMonths(-2);
            bool hasDuplicates = _context.Notificacoes.Any(n => n.Idpacient == Idpacient && n.datenotify >= difference);

            return hasDuplicates;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Notificacao notificacao, int Idpacient)
        {
            if (Duplicate(Idpacient))
            {
                ModelState.AddModelError("Duplicatas", "O paciente já tem notificações nos últimos dois meses.");
                ViewBag.Idpacient = Idpacient;
                return View(notificacao);
            }

            int sintomasMarcados = 0;
            if (notificacao.fever) sintomasMarcados++;
            if (notificacao.myalgia) sintomasMarcados++;
            if (notificacao.headache) sintomasMarcados++;
            if (notificacao.rash) sintomasMarcados++;
            if (notificacao.vomit) sintomasMarcados++;
            if (notificacao.nausea) sintomasMarcados++;
            if (notificacao.backPain) sintomasMarcados++;
            if (notificacao.conjunctivitis) sintomasMarcados++;
            if (notificacao.arthritis) sintomasMarcados++;
            if (notificacao.severeArthralgia) sintomasMarcados++;
            if (notificacao.petechiae) sintomasMarcados++;
            if (notificacao.leukopenia) sintomasMarcados++;
            if (notificacao.pTieproof) sintomasMarcados++;
            if (notificacao.nTieproof) sintomasMarcados++;
            if (notificacao.retroorbitalPain) sintomasMarcados++;

            if (sintomasMarcados >= 3)
            {
                if (ModelState.IsValid)
                {
                    for (int i = 1; i <= 8; i++)
                    {
                        DateTime? dataExame = null;
                        string resultadoExame = null;

                        // Obter valores dos campos de data e seleção
                        switch (i)
                        {
                            case 1:
                                dataExame = notificacao.cfsCollecting;
                                resultadoExame = notificacao.cfsStatus;
                                break;
                            case 2:
                                dataExame = notificacao.cssCollecting;
                                resultadoExame = notificacao.cssStatus;
                                break;
                            case 3:
                                dataExame = notificacao.prntCollecting;
                                resultadoExame = notificacao.prntStatus;
                                break;
                            case 4:
                                dataExame = notificacao.dsCollecting;
                                resultadoExame = notificacao.dsStatus;
                                break;
                            case 5:
                                dataExame = notificacao.ns1Collecting;
                                resultadoExame = notificacao.ns1Status;
                                break;
                            case 6:
                                dataExame = notificacao.insCollecting;
                                resultadoExame = notificacao.insStatus;
                                break;
                            case 7:
                                dataExame = notificacao.rtpcrCollecting;
                                resultadoExame = notificacao.rtpcrStatus;
                                break;
                            case 8:
                                dataExame = notificacao.cssCollecting;
                                resultadoExame = notificacao.cssStatus;
                                break;
                        }

                        if (dataExame.HasValue)
                        {
                            if (resultadoExame == "Não Realizado")
                            {
                                ModelState.AddModelError($"ResultExame{i}", "Se o exame foi realizado, o resultado não pode ser 'não realizado'.");
                                ViewBag.Idpacient = Idpacient;
                                return View(notificacao);
                            }
                        }
                        else if (((notificacao.serotype == "Realizado") && (notificacao.srtSelect == null)))
                        {
                            ModelState.AddModelError("Sorotipo", "Se foi realizado o exame de sorótipo um valor válido deve ser selecionado");
                            ViewBag.Idpacient = Idpacient;
                            return View(notificacao);
                        }else if(((notificacao.serotype == "Não Realizado") && !(notificacao.srtSelect == null)))
                        {
                            ModelState.AddModelError("Sorotipo", "Se não foi realizado o exame de sorótipo então a seleção deve ser deixada vazia");
                            ViewBag.Idpacient = Idpacient;
                            return View(notificacao);
                        }
                        else
                        {
                            if (resultadoExame != "Não Realizado")
                            {
                                ModelState.AddModelError($"ResultExame{i}", "Se o exame não foi realizado, o resultado deve ser 'não realizado'.");
                                ViewBag.Idpacient = Idpacient;
                                return View(notificacao);
                            }
                        }
                    }

                    // Validar sintomas de dengue com sinais de alarme
                    if (notificacao.pHypotension || notificacao.plateletsFall || notificacao.pVomiting || notificacao.scaPain || notificacao.loIrritability || notificacao.moBleeding || notificacao.piHematocrit)
                    {
                        if (notificacao.alarmingDate == null || notificacao.alarmingDate > notificacao.datenotify)
                        {
                            ModelState.AddModelError("DateAlarm", "Se o paciente possui um dos sintomas de Dengue com sinais de alarme a data de inicio dos sinais de alarme deve estar preenchida e ser menor ou igual a data de notificação.");
                            ViewBag.Idpacient = Idpacient;
                            return View(notificacao);
                        }
                    }

                    // Validar sintomas de dengue com sinais de gravidade
                    if (notificacao.hge2cm || notificacao.iLiquids || notificacao.wuPulse || notificacao.convergentbp || notificacao.crTime || notificacao.afrInsuficiency || notificacao.tachycardia || notificacao.cExtremities || notificacao.lsHypotension || notificacao.hematemesis || notificacao.melena || notificacao.bMetrorrhagia || notificacao.cnsBleeding || notificacao.astalt || notificacao.myocarditis || notificacao.tachycardia || notificacao.aConciousness || notificacao.aOrgans)
                    {
                        if (notificacao.sinDateinit == null || notificacao.sinDateinit > notificacao.datenotify)
                        {
                            ModelState.AddModelError("DateGravity", "Se o paciente possui um dos sintomas de Dengue grave a data de inicio dos sinais de gravidade deve estar preenchida e ser menor ou igual a data de notificação.");
                            ViewBag.Idpacient = Idpacient;
                            return View(notificacao);
                        }
                    }

                    // Outras validações das checkboxes e campos correspondentes
                    if (notificacao.recentTravel && (string.IsNullOrWhiteSpace(notificacao.travelPlace) || (notificacao.goTravel == null) || (notificacao.backTravel == null) || (notificacao.goTravel>notificacao.backTravel)))
                    {
                        ModelState.AddModelError("Viagem", "O campo de Informações de Destino da viagem é obrigatório quando a opção está marcada, além disso a data de ida não pode ser marcada como uma data maior que a data de retorno.");
                        ViewBag.Idpacient = Idpacient;
                        return View(notificacao);
                    }
                    else if (!(notificacao.recentTravel) && (!(string.IsNullOrWhiteSpace(notificacao.travelPlace)) || !(notificacao.goTravel == null) || !(notificacao.backTravel == null)))
                    {
                        ModelState.AddModelError("Viagem", "Se a opção não estiver marcada então os campos de data de ida data de retorno e Destino não devem ser preenchidos.");
                        ViewBag.Idpacient = Idpacient;
                        return View(notificacao);
                    }

                    if (notificacao.visitor && string.IsNullOrWhiteSpace(notificacao.eeArea))
                    {
                        ModelState.AddModelError("Visitante", "O campo 'De qual área endêmica/epidêmica' é obrigatório quando a opção está marcada.");
                        ViewBag.Idpacient = Idpacient;
                        return View(notificacao);
                    }
                    else if(!(notificacao.visitor) && !(string.IsNullOrWhiteSpace(notificacao.eeArea)))
                    {
                        ModelState.AddModelError("Visitante", "Se a opção não estiver marcada então o campo deve ser deixado vazio.");
                        ViewBag.Idpacient = Idpacient;
                        return View(notificacao);
                    }

                    if (notificacao.pMedication && string.IsNullOrWhiteSpace(notificacao.medName))
                    {
                        ModelState.AddModelError("Medicamento", "O campo de 'Nome do medicamento' é obrigatório quando a opção está marcada.");
                        ViewBag.Idpacient = Idpacient;
                        return View(notificacao);
                    }
                    else if(!(notificacao.pMedication) && !(string.IsNullOrWhiteSpace(notificacao.medName)))
                    {
                        ModelState.AddModelError("Medicamento", "Se a opção não estiver marcada então o campo deve ser deixado vazio.");
                        ViewBag.Idpacient = Idpacient;
                        return View(notificacao);
                    }

                    if (notificacao.pEncaminhation)
                    {
                        if (string.IsNullOrWhiteSpace(notificacao.ePlace) || string.IsNullOrWhiteSpace(notificacao.motive))
                        {
                            ModelState.AddModelError("Encaminhamento", "Os campos 'Nome do outro serviço' e 'Motivo do encaminhamento' são obrigatórios quando a opção está marcada.");
                            ViewBag.Idpacient = Idpacient;
                            return View(notificacao);
                        }
                    }
                    else
                    {
                        if (!(string.IsNullOrWhiteSpace(notificacao.ePlace)) || !(string.IsNullOrWhiteSpace(notificacao.motive)))
                        {
                            ModelState.AddModelError("Encaminhamento", "Se a opção não estiver marcada então os campos devem ser deixados vazios.");
                            ViewBag.Idpacient = Idpacient;
                            return View(notificacao);
                        }
                    }

                    if (notificacao.hospitalization)
                    {
                        if ((notificacao.hospDate == null) || string.IsNullOrWhiteSpace(notificacao.hospUF) || string.IsNullOrWhiteSpace(notificacao.hospMun) || string.IsNullOrWhiteSpace(notificacao.hospName))
                        {
                            ModelState.AddModelError("Hospitalização", "Todos os campos de Internação são obrigatórios quando a opção está marcada.");
                            ViewBag.Idpacient = Idpacient;
                            return View(notificacao);
                        }
                    }
                    else
                    {
                        if (!(notificacao.hospDate == null) || !(string.IsNullOrWhiteSpace(notificacao.hospUF)) || !(string.IsNullOrWhiteSpace(notificacao.hospMun)) || !(string.IsNullOrWhiteSpace(notificacao.hospName)))
                        {
                            ModelState.AddModelError("Hospitalização", "Se opção não estiver marcada então os campos devem ser deixados vazios.");
                            ViewBag.Idpacient = Idpacient;
                            return View(notificacao);
                        }
                    }

                    if(notificacao.closingDate>DateTime.Now)
                    {
                        ModelState.AddModelError("Datas", "A data de encerramento não pode ser maior que a data/hora atual.");
                        ViewBag.Idpacient = Idpacient;
                        return View(notificacao);
                    }
                    else if (notificacao.datesynptoms <= notificacao.datenotify && notificacao.datenotify <= notificacao.dateinv && notificacao.dateinv <= notificacao.closingDate)
                    {
                        _context.Add(notificacao);
                        await _context.SaveChangesAsync();

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("Datas", "As datas devem ser inseridas corretamente.");
                        ViewBag.Idpacient = Idpacient;
                        return View(notificacao);
                    }
                }
                else
                {
                    ModelState.AddModelError("Modelo", "O modelo enviado é inválido.");
                    ViewBag.Idpacient = Idpacient;
                    return View(notificacao);
                }
            }
            else
            {
                ModelState.AddModelError("Sintomas", "É necessário marcar pelo menos 3 sintomas.");
                ViewBag.Idpacient = Idpacient;
                return View(notificacao);
            }
        }

        public async Task<IActionResult> Edit(long Idnotify)
        {
            var notificacao = await _context.Notificacoes.FindAsync(Idnotify);
            if (notificacao == null)
            {
                return NotFound();
            }
            return View(notificacao);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Notificacao notificacao)
        {
            int sintomasMarcados = 0;
            if (notificacao.fever) sintomasMarcados++;
            if (notificacao.myalgia) sintomasMarcados++;
            if (notificacao.headache) sintomasMarcados++;
            if (notificacao.rash) sintomasMarcados++;
            if (notificacao.vomit) sintomasMarcados++;
            if (notificacao.nausea) sintomasMarcados++;
            if (notificacao.backPain) sintomasMarcados++;
            if (notificacao.conjunctivitis) sintomasMarcados++;
            if (notificacao.arthritis) sintomasMarcados++;
            if (notificacao.severeArthralgia) sintomasMarcados++;
            if (notificacao.petechiae) sintomasMarcados++;
            if (notificacao.leukopenia) sintomasMarcados++;
            if (notificacao.pTieproof) sintomasMarcados++;
            if (notificacao.nTieproof) sintomasMarcados++;
            if (notificacao.retroorbitalPain) sintomasMarcados++;

            if (sintomasMarcados >= 3)
            {
                if (ModelState.IsValid)
                {
                    for (int i = 1; i <= 8; i++)
                    {
                        DateTime? dataExame = null;
                        string resultadoExame = null;

                        // Obter valores dos campos de data e seleção
                        switch (i)
                        {
                            case 1:
                                dataExame = notificacao.cfsCollecting;
                                resultadoExame = notificacao.cfsStatus;
                                break;
                            case 2:
                                dataExame = notificacao.cssCollecting;
                                resultadoExame = notificacao.cssStatus;
                                break;
                            case 3:
                                dataExame = notificacao.prntCollecting;
                                resultadoExame = notificacao.prntStatus;
                                break;
                            case 4:
                                dataExame = notificacao.dsCollecting;
                                resultadoExame = notificacao.dsStatus;
                                break;
                            case 5:
                                dataExame = notificacao.ns1Collecting;
                                resultadoExame = notificacao.ns1Status;
                                break;
                            case 6:
                                dataExame = notificacao.insCollecting;
                                resultadoExame = notificacao.insStatus;
                                break;
                            case 7:
                                dataExame = notificacao.rtpcrCollecting;
                                resultadoExame = notificacao.rtpcrStatus;
                                break;
                            case 8:
                                dataExame = notificacao.cssCollecting;
                                resultadoExame = notificacao.cssStatus;
                                break;
                        }

                        if (dataExame.HasValue)
                        {
                            if (resultadoExame == "Não Realizado")
                            {
                                ModelState.AddModelError($"ResultExame{i}", "Se o exame foi realizado, o resultado não pode ser 'não realizado'.");
                                return View(notificacao);
                            }
                        }
                        else if (((notificacao.serotype == "Realizado") && (notificacao.srtSelect == null)))
                        {
                            ModelState.AddModelError("Sorotipo", "Se foi realizado o exame de sorótipo um valor válido deve ser selecionado");
                            return View(notificacao);
                        }
                        else if (((notificacao.serotype == "Não Realizado") && !(notificacao.srtSelect == null)))
                        {
                            ModelState.AddModelError("Sorotipo", "Se não foi realizado o exame de sorótipo então a seleção deve ser deixada vazia");
                            return View(notificacao);
                        }
                        else
                        {
                            if (resultadoExame != "Não Realizado")
                            {
                                ModelState.AddModelError($"ResultExame{i}", "Se o exame não foi realizado, o resultado deve ser 'não realizado'.");
                                return View(notificacao);
                            }
                        }
                    }

                    // Validar sintomas de dengue com sinais de alarme
                    if (notificacao.pHypotension || notificacao.plateletsFall || notificacao.pVomiting || notificacao.scaPain || notificacao.loIrritability || notificacao.moBleeding || notificacao.piHematocrit)
                    {
                        if (notificacao.alarmingDate == null || notificacao.alarmingDate > notificacao.datenotify)
                        {
                            ModelState.AddModelError("DateAlarm", "Se o paciente possui um dos sintomas de Dengue com sinais de alarme a data de inicio dos sinais de alarme deve estar preenchida e ser menor ou igual a data de notificação.");
                            return View(notificacao);
                        }
                    }

                    // Validar sintomas de dengue com sinais de gravidade
                    if (notificacao.hge2cm || notificacao.iLiquids || notificacao.wuPulse || notificacao.convergentbp || notificacao.crTime || notificacao.afrInsuficiency || notificacao.tachycardia || notificacao.cExtremities || notificacao.lsHypotension || notificacao.hematemesis || notificacao.melena || notificacao.bMetrorrhagia || notificacao.cnsBleeding || notificacao.astalt || notificacao.myocarditis || notificacao.tachycardia || notificacao.aConciousness || notificacao.aOrgans)
                    {
                        if (notificacao.sinDateinit == null || notificacao.sinDateinit > notificacao.datenotify)
                        {
                            ModelState.AddModelError("DateGravity", "Se o paciente possui um dos sintomas de Dengue grave a data de inicio dos sinais de gravidade deve estar preenchida e ser menor ou igual a data de notificação.");
                            return View(notificacao);
                        }
                    }

                    // Outras validações das checkboxes e campos correspondentes
                    if (notificacao.recentTravel && (string.IsNullOrWhiteSpace(notificacao.travelPlace) || (notificacao.goTravel == null) || (notificacao.backTravel == null) || (notificacao.goTravel > notificacao.backTravel)))
                    {
                        ModelState.AddModelError("Viagem", "O campo de Informações de Destino da viagem é obrigatório quando a opção está marcada, além disso a data de ida não pode ser marcada como uma data maior que a data de retorno.");
                        return View(notificacao);
                    }
                    else if (!(notificacao.recentTravel) && (!(string.IsNullOrWhiteSpace(notificacao.travelPlace)) || !(notificacao.goTravel == null) || !(notificacao.backTravel == null)))
                    {
                        ModelState.AddModelError("Viagem", "Se a opção não estiver marcada então os campos de data de ida data de retorno e Destino não devem ser preenchidos.");
                        return View(notificacao);
                    }

                    if (notificacao.visitor && string.IsNullOrWhiteSpace(notificacao.eeArea))
                    {
                        ModelState.AddModelError("Visitante", "O campo 'De qual área endêmica/epidêmica' é obrigatório quando a opção está marcada.");
                        return View(notificacao);
                    }
                    else if (!(notificacao.visitor) && !(string.IsNullOrWhiteSpace(notificacao.eeArea)))
                    {
                        ModelState.AddModelError("Visitante", "Se a opção não estiver marcada então o campo deve ser deixado vazio.");
                        return View(notificacao);
                    }

                    if (notificacao.pMedication && string.IsNullOrWhiteSpace(notificacao.medName))
                    {
                        ModelState.AddModelError("Medicamento", "O campo de 'Nome do medicamento' é obrigatório quando a opção está marcada.");
                        return View(notificacao);
                    }
                    else if (!(notificacao.pMedication) && !(string.IsNullOrWhiteSpace(notificacao.medName)))
                    {
                        ModelState.AddModelError("Medicamento", "Se a opção não estiver marcada então o campo deve ser deixado vazio.");
                        return View(notificacao);
                    }

                    if (notificacao.pEncaminhation)
                    {
                        if (string.IsNullOrWhiteSpace(notificacao.ePlace) || string.IsNullOrWhiteSpace(notificacao.motive))
                        {
                            ModelState.AddModelError("Encaminhamento", "Os campos 'Nome do outro serviço' e 'Motivo do encaminhamento' são obrigatórios quando a opção está marcada.");
                            return View(notificacao);
                        }
                    }
                    else
                    {
                        if (!(string.IsNullOrWhiteSpace(notificacao.ePlace)) || !(string.IsNullOrWhiteSpace(notificacao.motive)))
                        {
                            ModelState.AddModelError("Encaminhamento", "Se a opção não estiver marcada então os campos devem ser deixados vazios.");
                            return View(notificacao);
                        }
                    }

                    if (notificacao.hospitalization)
                    {
                        if ((notificacao.hospDate == null) || string.IsNullOrWhiteSpace(notificacao.hospUF) || string.IsNullOrWhiteSpace(notificacao.hospMun) || string.IsNullOrWhiteSpace(notificacao.hospName))
                        {
                            ModelState.AddModelError("Hospitalização", "Todos os campos de Internação são obrigatórios quando a opção está marcada.");
                            return View(notificacao);
                        }
                    }
                    else
                    {
                        if (!(notificacao.hospDate == null) || !(string.IsNullOrWhiteSpace(notificacao.hospUF)) || !(string.IsNullOrWhiteSpace(notificacao.hospMun)) || !(string.IsNullOrWhiteSpace(notificacao.hospName)))
                        {
                            ModelState.AddModelError("Hospitalização", "Se opção não estiver marcada então os campos devem ser deixados vazios.");
                            return View(notificacao);
                        }
                    }

                    if (notificacao.closingDate > DateTime.Now)
                    {
                        ModelState.AddModelError("Datas", "A data de encerramento não pode ser maior que a data/hora atual.");
                        return View(notificacao);
                    }
                    else if ((notificacao.datesynptoms <= notificacao.datenotify && notificacao.datenotify <= notificacao.dateinv && notificacao.dateinv <= notificacao.closingDate))
                    {
                        _context.Update(notificacao);
                        await _context.SaveChangesAsync();

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("Datas", "As datas devem ser inseridas corretamente.");
                        return View(notificacao);
                    }
                }
                else
                {
                    ModelState.AddModelError("Modelo", "O modelo enviado é inválido.");
                    return View(notificacao);
                }
            }
            else
            {
                ModelState.AddModelError("Sintomas", "É necessário marcar pelo menos 3 sintomas.");
                return View(notificacao);
            }
        }

        // GET: Notificacoes/Delete/5
        public async Task<IActionResult> Delete(long Idnotify)
        {
            var notificacao = await _context.Notificacoes.FirstOrDefaultAsync(m => m.Idnotify == Idnotify);
            if (notificacao == null)
                return NotFound();

            return View(notificacao);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(long Idnotify)
        {
            var notificacao = await _context.Notificacoes.FindAsync(Idnotify);
            if (notificacao != null)
            {
                _context.Notificacoes.Remove(notificacao);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }
    }
}
