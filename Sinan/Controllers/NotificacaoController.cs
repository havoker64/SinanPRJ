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
    
    public class NotificacaoController : Controller
    {
        private readonly AppDBcontext _context;

        public NotificacaoController(AppDBcontext context)
        {
            _context = context;
        }

        // GET: Notificacao
        public async Task<IActionResult> nIndex()
        {
              return _context.Notificacoes != null ? 
                          View(await _context.Notificacoes.ToListAsync()) :
                          Problem("Entity set 'AppDBcontext.Notificacoes'  is null.");
        }

        // GET: Notificacao/Details/5
        public async Task<IActionResult> nDetails(int? id)
        {
            if (id == null || _context.Notificacoes == null)
            {
                return NotFound();
            }

            var notificacao = await _context.Notificacoes
                .FirstOrDefaultAsync(m => m.Idnotify == id);
            if (notificacao == null)
            {
                return NotFound();
            }

            return View(notificacao);
        }

        // GET: Notificacao/Create
        public IActionResult nCreate()
        {
            return View();
        }
        
        public async Task<IActionResult> nSearch(long? suscard)
        {
            if (suscard == null)
            {
                return NotFound();
            }

            var sus = await _context.Notificacoes.FirstOrDefaultAsync(q => q.suscard == suscard);
            if (sus == null)
            {
                Response.StatusCode = 404;
                return View("PacienteNotFound", suscard);
            }
            return View(sus);
        }
        // POST: Notificacao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> nCreate([Bind("Idnotify,Agravo,datenotify,us,datesynptoms,pregnant,dateinv,occupation,fever,myalgia,headache,rash,vomit,nausea,backPain,conjunctivitis,arthritis,severeArthralgia,petechiae,leukopenia,pTieproof,nTieproof,retroorbitalPain,diabetes,hDiseases,liverDiseases,ckDisease,hypertension,paDisease,aiDisease,cfSerology,cfsCollecting,cfsStatus,csSerology,cssCollecting,cssStatus,prnt,prntCollecting,prntStatus,dSerology,dsCollecting,dsStatus,ns1,ns1Collecting,ns1Status,insulation,insCollecting,insStatus,rtpcr,rtpcrCollecting,rtpcrStatus,serotype,srtSelect,alarmingDengue,pHypotension,plateletsFall,pVomiting,scaPain,loIrritability,moBleeding,piHematocrit,hge2cm,iLiquids,severeDengue,wuPulse,convergentbp,crTime,afrInsuficiency,tachycardia,cExtremities,lsHypotension,melena,bMetrorrhagia,cnsBleeding,astalt,myocarditis,aConciousness,aOrgans,organName,patientClass,recentTravel,travelPlace,goTravel,backTravel,visitor,eeArea,areaKnlg,pMedication,medName,pEncaminhation,ePlace,motive,iName,iUs,iFunction")] Notificacao notificacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(notificacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(notificacao);
        }

        // GET: Notificacao/Edit/5
        public async Task<IActionResult> nEdit(int? id)
        {
            if (id == null || _context.Notificacoes == null)
            {
                return NotFound();
            }

            var notificacao = await _context.Notificacoes.FindAsync(id);
            if (notificacao == null)
            {
                return NotFound();
            }
            return View(notificacao);
        }

        // POST: Notificacao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> nEdit(int id, [Bind("Idnotify,Agravo,datenotify,us,datesynptoms,pregnant,dateinv,occupation,fever,myalgia,headache,rash,vomit,nausea,backPain,conjunctivitis,arthritis,severeArthralgia,petechiae,leukopenia,pTieproof,nTieproof,retroorbitalPain,diabetes,hDiseases,liverDiseases,ckDisease,hypertension,paDisease,aiDisease,cfSerology,cfsCollecting,cfsStatus,csSerology,cssCollecting,cssStatus,prnt,prntCollecting,prntStatus,dSerology,dsCollecting,dsStatus,ns1,ns1Collecting,ns1Status,insulation,insCollecting,insStatus,rtpcr,rtpcrCollecting,rtpcrStatus,serotype,srtSelect,alarmingDengue,pHypotension,plateletsFall,pVomiting,scaPain,loIrritability,moBleeding,piHematocrit,hge2cm,iLiquids,severeDengue,wuPulse,convergentbp,crTime,afrInsuficiency,tachycardia,cExtremities,lsHypotension,melena,bMetrorrhagia,cnsBleeding,astalt,myocarditis,aConciousness,aOrgans,organName,patientClass,recentTravel,travelPlace,goTravel,backTravel,visitor,eeArea,areaKnlg,pMedication,medName,pEncaminhation,ePlace,motive,iName,iUs,iFunction")] Notificacao notificacao)
        {
            if (id != notificacao.Idnotify)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(notificacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NotificacaoExists(notificacao.Idnotify))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(notificacao);
        }

        // GET: Notificacao/Delete/5
        public async Task<IActionResult> nDelete(int? id)
        {
            if (id == null || _context.Notificacoes == null)
            {
                return NotFound();
            }

            var notificacao = await _context.Notificacoes
                .FirstOrDefaultAsync(m => m.Idnotify == id);
            if (notificacao == null)
            {
                return NotFound();
            }

            return View(notificacao);
        }

        // POST: Notificacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Notificacoes == null)
            {
                return Problem("Entity set 'AppDBcontext.Notificacoes'  is null.");
            }
            var notificacao = await _context.Notificacoes.FindAsync(id);
            if (notificacao != null)
            {
                _context.Notificacoes.Remove(notificacao);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NotificacaoExists(int id)
        {
          return (_context.Notificacoes?.Any(e => e.Idnotify == id)).GetValueOrDefault();
        }
    }
}
