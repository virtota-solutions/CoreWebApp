﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PCVTry.Models;

namespace PCVTry.Controllers
{
    public class UserController : Controller
    {
        private readonly MVCContext _context;

        public UserController(MVCContext context)
        {
            _context = context;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            return View(await _context.User.ToListAsync());
        }


        public IActionResult UserInformation()
        {
            return View();
        }
     

        // GET: User/Create
        public IActionResult RequestInfoesCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RequestInfoesCreate([Bind("TodayDate,RequestType,RequestByName,EffectiveStart,EffectiveEnd,RequestId")] Requestinfo requestinfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(requestinfo);
                await _context.SaveChangesAsync();
                return RedirectToAction("UserRequirementsCreate", "User");
            }
            return View(requestinfo);
        }
       
        public IActionResult UserRequirementsCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UserRequirementsCreate([Bind("UserReqId,FloorNum,CubeNum,DidNum,DualMon,RemoAcc,RemoLap,Mobile,UserStatus,UserName")] UserRequirements userRequirements)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userRequirements);
                await _context.SaveChangesAsync();
                return RedirectToAction("VmsRolegroupsCreate", "User");
            }
            return View(userRequirements);
        }

        public IActionResult VmsRolegroupsCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> VmsRolegroupsCreate([Bind("VmsroleGroupId,AccountGroup,AdminSupport,Assignor,Auditor,CliServiDeptMgr,CliServiGroup,CommercialGroup,ContractorQc,Itgroup,ProcessingShippingGroup,QcsupervisorLead,Qc,SalesGroup,StatusGroup,VendorRelationsGroup")] VmsRolegroup vmsRolegroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vmsRolegroup);
                await _context.SaveChangesAsync();
                return RedirectToAction("OtsAccessCreate", "User");
            }
            return View(vmsRolegroup);
        }
        public IActionResult OtsAccessCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OtsAccessCreate([Bind("OtsAccessId,Return,MultiAssign,DeleteOrder,ToReassign,RecreateOrder,AppraisalTagShip,MaintainTagReasons,MaintainClariReasons,AuditAdmin,DisputeQueueAccess")] OtsAccess otsAccess)
        {
            if (ModelState.IsValid)
            {
                _context.Add(otsAccess);
                await _context.SaveChangesAsync();
                return RedirectToAction("BpoRoleGroupsCreate", "User");
            }
            return View(otsAccess);
        }
        public IActionResult BpoRoleGroupsCreate()
        {
            return View();
        }

        // POST: BpoRolegroups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BpoRoleGroupsCreate([Bind("Bpoid,Bpoadmin,ContractQc,FdicQc,HoldOrders,MarkOrdersShipped,QcBasic,QcPlus,QcSupervisor,ViewRules")] BpoRolegroup bpoRolegroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bpoRolegroup);
                await _context.SaveChangesAsync();
                return RedirectToAction("LrvRoleGroupCreate", "User");
            }
            return View(bpoRolegroup);
        }
        public IActionResult LrvRoleGroupCreate()
        {
            return View();
        }

        // POST: LrvRolegroups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LrvRoleGroupCreate([Bind("LrvId,LrvAdmin,FannieQc,RegularQc,AllQueues")] LrvRolegroup lrvRolegroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lrvRolegroup);
                await _context.SaveChangesAsync();
                return RedirectToAction();
            }
            return View(lrvRolegroup);
        }


    }
    
}
