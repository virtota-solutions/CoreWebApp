using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PCVTry.Models;

namespace PCVTry.Controllers
{
    public class VmsRolegroupsController : Controller
    {
        private readonly MVCContext _context;

        public VmsRolegroupsController(MVCContext context)
        {
            _context = context;
        }

        // GET: VmsRolegroups
        public async Task<IActionResult> Index()
        {
            return View(await _context.VmsRolegroup.ToListAsync());
        }

        // GET: VmsRolegroups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vmsRolegroup = await _context.VmsRolegroup
                .FirstOrDefaultAsync(m => m.VmsroleGroupId == id);
            if (vmsRolegroup == null)
            {
                return NotFound();
            }

            return View(vmsRolegroup);
        }

        // GET: VmsRolegroups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VmsRolegroups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VmsroleGroupId,AccountGroup,AdminSupport,Assignor,Auditor,CliServiDeptMgr,CliServiGroup,CommercialGroup,ContractorQc,Itgroup,ProcessingShippingGroup,QcsupervisorLead,Qc,SalesGroup,StatusGroup,VendorRelationsGroup")] VmsRolegroup vmsRolegroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vmsRolegroup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vmsRolegroup);
        }

        // GET: VmsRolegroups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vmsRolegroup = await _context.VmsRolegroup.FindAsync(id);
            if (vmsRolegroup == null)
            {
                return NotFound();
            }
            return View(vmsRolegroup);
        }

        // POST: VmsRolegroups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VmsroleGroupId,AccountGroup,AdminSupport,Assignor,Auditor,CliServiDeptMgr,CliServiGroup,CommercialGroup,ContractorQc,Itgroup,ProcessingShippingGroup,QcsupervisorLead,Qc,SalesGroup,StatusGroup,VendorRelationsGroup")] VmsRolegroup vmsRolegroup)
        {
            if (id != vmsRolegroup.VmsroleGroupId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vmsRolegroup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VmsRolegroupExists(vmsRolegroup.VmsroleGroupId))
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
            return View(vmsRolegroup);
        }

        // GET: VmsRolegroups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vmsRolegroup = await _context.VmsRolegroup
                .FirstOrDefaultAsync(m => m.VmsroleGroupId == id);
            if (vmsRolegroup == null)
            {
                return NotFound();
            }

            return View(vmsRolegroup);
        }

        // POST: VmsRolegroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vmsRolegroup = await _context.VmsRolegroup.FindAsync(id);
            _context.VmsRolegroup.Remove(vmsRolegroup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VmsRolegroupExists(int id)
        {
            return _context.VmsRolegroup.Any(e => e.VmsroleGroupId == id);
        }
    }
}
