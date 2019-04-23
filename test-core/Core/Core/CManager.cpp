//+------------------------------------------------------------------+
//|                                                       MetaTrader |
//|                   Copyright 2001-2014, MetaQuotes Software Corp. |
//|                                        http://www.metaquotes.net |
//+------------------------------------------------------------------+
#include "stdafx.h"
#include "MT4ManagerAPI.h"
#include "CManager.h" 
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+

namespace Core {
	CManager::CManager() : m_factory("mtmanapi.dll"), m_manager(NULL)
	{
		m_factory.WinsockStartup();
		if (m_factory.IsValid() == FALSE || (m_manager = m_factory.Create(ManAPIVersion)) == NULL)
		{
			printf("Failed to create manager interface\n");
			return;
		}


	}

	CManager::~CManager() {
		if (m_manager != NULL) { m_manager->Release(); m_manager = NULL; }
		m_factory.WinsockCleanup();
	}

	bool CManager::IsValid() { return(m_manager != NULL); }
	CManagerInterface* CManager:: operator->() { return(m_manager); }
}


