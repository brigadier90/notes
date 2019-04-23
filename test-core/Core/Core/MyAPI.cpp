#include "stdafx.h"
#include "MyAPI.h"
#include "CMAnager.h"



namespace Core {

	MyAPI::MyAPI() {

	}

	int MyAPI::connect() {
		CManager manager;
		int res = RET_ERROR;

		if (manager.IsValid() == FALSE) return(-1);
		//--- connect
		if ((res = manager->Connect("52.178.132.0")) != RET_OK || (res = manager->Login(100, "123abc")) != RET_OK)
		{
			printf("Connect failed: %d (%s)\n", res, manager->ErrorDescription(res));
			return(-1);
		}
		printf("Connected as '100'\n");

		return 0;
	}
}