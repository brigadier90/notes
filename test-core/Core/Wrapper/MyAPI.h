#pragma once
#include "ManagedObject.h"
#include "../Core/Core.h"

using namespace System;
namespace CLI
{
	public ref class MyAPI : public ManagedObject<Core::MyAPI>
	{
	public:

		MyAPI();
		int connect();
	};
}