#pragma once
#include "MT4ManagerAPI.h"


namespace Core {
	class CManager {
	private:
		CManagerFactory   m_factory;
		CManagerInterface *m_manager;

	public:
		CManager();

		~CManager();
		bool IsValid();
		CManagerInterface* operator->();


	};
}



