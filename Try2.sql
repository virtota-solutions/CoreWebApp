CREATE TABLE "user_table" (
  "userID" int NOT NULL,
  "LastName" varchar(255) DEFAULT NULL,
  "FirstName" varchar(255) DEFAULT NULL,
  "department" varchar(255) DEFAULT NULL,
  "office" varchar(255) DEFAULT NULL,
  "managerName" varchar(255) DEFAULT NULL,
  "isManager" bit DEFAULT NULL,
  "dateStart" date DEFAULT NULL,
  "dateEnd" date DEFAULT NULL,
  PRIMARY KEY ("userID")
) 


CREATE TABLE "requestinfo" (
  "today_Date" date DEFAULT NULL,
  "requestType" varchar(7) DEFAULT NULL,
  "requestByName" varchar(25) DEFAULT NULL,
  "effectiveStart" datetime DEFAULT NULL,
  "effectiveEnd" datetime DEFAULT NULL,
  "request_ID" int NOT NULL,
  PRIMARY KEY ("request_ID"),
) 

CREATE TABLE "user" (
  "username" varchar(16) NOT NULL,
  "password" varchar(32) NOT NULL,
  "userLog_ID" int NOT NULL,
  PRIMARY KEY ("userLog_ID"),
) 

CREATE TABLE "user_requirements" (
  "userReqID" int NOT NULL,
  "floorNum" int DEFAULT NULL,
  "cubeNum" int DEFAULT NULL,
  "didNum" bit DEFAULT NULL,
  "dualMon" bit DEFAULT NULL,
  "remoAcc" bit DEFAULT NULL,
  "remoLap" bit DEFAULT NULL,
  "mobile" bit DEFAULT NULL,
  "userStatus" varchar(3) DEFAULT NULL,
  "userName" varchar(255) DEFAULT NULL,
  PRIMARY KEY ("userReqID"),
) 


CREATE TABLE "addi_access" (
  "AddiAccessID" int NOT NULL,
  "PCI" bit DEFAULT NULL,
  "FDIC" bit DEFAULT NULL,
  "CRM" bit DEFAULT NULL,
  "CopyOf" varchar(45) DEFAULT NULL,
  PRIMARY KEY ("AddiAccessID")
)

CREATE TABLE "bpo_rolegroup" (
  "BPOID" int NOT NULL,
  "BPOAdmin" bit DEFAULT NULL,
  "ContractQC" bit DEFAULT NULL,
  "FDIC_QC" bit DEFAULT NULL,
  "HoldOrders" bit DEFAULT NULL,
  "MarkOrdersShipped" bit DEFAULT NULL,
  "QC_Basic" bit DEFAULT NULL,
  "QC_Plus" bit DEFAULT NULL,
  "QC_Supervisor" bit DEFAULT NULL,
  "View_Rules" bit DEFAULT NULL,
  PRIMARY KEY ("BPOID")
) 

CREATE TABLE "lrv_rolegroup" (
  "LRV_ID" int NOT NULL,
  "LRV_Admin" bit DEFAULT NULL,
  "FannieQC" bit DEFAULT NULL,
  "RegularQC" bit DEFAULT NULL,
  "AllQueues" bit DEFAULT NULL,
  PRIMARY KEY ("LRV_ID")
) 

CREATE TABLE "ots_access" (
  "ots_accessID" int NOT NULL,
  "Return" bit DEFAULT NULL,
  "MultiAssign" bit DEFAULT NULL,
  "DeleteOrder" bit DEFAULT NULL,
  "ToReassign" bit DEFAULT NULL,
  "RecreateOrder" bit DEFAULT NULL,
  "AppraisalTagShip" bit DEFAULT NULL,
  "MaintainTagReasons" bit DEFAULT NULL,
  "MaintainClariReasons" bit DEFAULT NULL,
  "AuditAdmin" bit DEFAULT NULL,
  "DisputeQueueAccess" bit DEFAULT NULL,
  PRIMARY KEY ("ots_accessID")
) 

CREATE TABLE "vms_rolegroup" (
  "VMSRoleGroupID" int NOT NULL,
  "AccountGroup" bit DEFAULT NULL,
  "AdminSupport" bit DEFAULT NULL,
  "Assignor" bit DEFAULT NULL,
  "Auditor" bit DEFAULT NULL,
  "CliServiDeptMgr" bit DEFAULT NULL,
  "CliServiGroup" bit DEFAULT NULL,
  "CommercialGroup" bit DEFAULT NULL,
  "ContractorQC" bit DEFAULT NULL,
  "ITGroup" bit DEFAULT NULL,
  "ProcessingShippingGroup" bit DEFAULT NULL,
  "QCSupervisorLead" bit DEFAULT NULL,
  "QC" bit DEFAULT NULL,
  "SalesGroup" bit DEFAULT NULL,
  "StatusGroup" bit DEFAULT NULL,
  "VendorRelationsGroup" bit DEFAULT NULL,
  PRIMARY KEY ("VMSRoleGroupID")
) 

CREATE TABLE "applicationaccess" (
  "appID" int NOT NULL,
  "VMSroleGroup" int DEFAULT NULL,
  "addAccess" int DEFAULT NULL,
  "OTSAccess" int DEFAULT NULL,
  "BPORoleGroup" int DEFAULT NULL,
  "LRVroleGroup" int DEFAULT NULL,
  "mas500Access" varchar(255) DEFAULT NULL,
  PRIMARY KEY ("appID"),
  CONSTRAINT "addi" FOREIGN KEY ("addAccess") REFERENCES "addi_access" ("AddiAccessID"),
  CONSTRAINT "bpo" FOREIGN KEY ("BPORoleGroup") REFERENCES "bpo_rolegroup" ("BPOID"),
  CONSTRAINT "lrv" FOREIGN KEY ("LRVroleGroup") REFERENCES "lrv_rolegroup" ("LRV_ID"),
  CONSTRAINT "ots" FOREIGN KEY ("OTSAccess") REFERENCES "ots_access" ("ots_accessID"),
  CONSTRAINT "vms" FOREIGN KEY ("VMSroleGroup") REFERENCES "vms_rolegroup" ("VMSRoleGroupID")

)