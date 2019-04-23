#include "MyAPI.h"

namespace CLI
{
	MyAPI::MyAPI()
		: ManagedObject(new Core::MyAPI())
	{
		Console::WriteLine("Creating a new MyAPI-wrapper object!");
	}
	int MyAPI::connect()
	{
		Console::WriteLine("The connect method from the Wrapper was called!");
		int  r = m_Instance->connect();
		Console::WriteLine("HEllooooooooooo");
		return r;
	}
}