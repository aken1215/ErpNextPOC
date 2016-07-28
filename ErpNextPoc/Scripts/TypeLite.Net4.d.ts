
 
 

 

/// <reference path="Enums.ts" />

declare module Aurora.ErpNext.ViewModel {
	interface AccountViewModel {
		Id: System.Guid;
		Test: string;
	}
	interface InfoSupportEditViewModel {
		Attachments: string[];
		Context: string;
		ManagerEMPNO: string;
		ManagerName: string;
		Title: string;
	}
	interface MemberViewModel {
		Id: System.Guid;
		Test: string;
	}
}
declare module System {
	interface Guid {
	}
}


