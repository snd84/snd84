#ifndef WIN32_LEAN_AND_MEAN
#define WIN32_LEAN_AND_MEAN
#endif
#ifndef NOMINMAX
#define NOMINMAX
#endif
#include <nn/nn_Windows.h>
#include <map>
#include "Inputkeyboard.h"
#include "Windows.h"
#include <iostream>
namespace {
	std::map<short, BYTE> CONST_VK = 
	{
		{0,VK_ESCAPE},
		{1,VK_LEFT},
		{2,VK_RIGHT},
		{3,VK_UP},
		{4,VK_DOWN},
		{5,VK_LEFT},
	};

	std::map<short, int> VK_on =
	{
		{0,0},
		{1,0},
		{2,0},
		{3,0},
		{4,0},
		{5,0},
	};

}

void Inputkeyboard::Initialize()
{

}

void Inputkeyboard::KeyCheck() {
	for (std::pair<short,BYTE> s: CONST_VK) {
		if (VK_on[s.first] == 0 || VK_on[s.first] == 3) {
			VK_on[s.first] = GetAsyncKeyState(CONST_VK[s.first]) ? 1 : 0;
		}else if(VK_on[s.first] == 1 || VK_on[s.first] == 2){
			VK_on[s.first] = GetAsyncKeyState(CONST_VK[s.first]) ? 2 : 3;
		}
	}
}

int Inputkeyboard::GetKeyInput(short s) {
	return GetAsyncKeyState(CONST_VK[s]);
}

int Inputkeyboard::GetKeyInput_On(short s) {
	return VK_on[s];
}

