// This file is part of Wintermute Engine
// For conditions of distribution and use, see copyright notice in license.txt
// http://dead-code.org/redir.php?target=wme


#include "dcgf.h"
#include "HWDeviceAudio.h"

//////////////////////////////////////////////////////////////////////
// Construction/Destruction
//////////////////////////////////////////////////////////////////////


//////////////////////////////////////////////////////////////////////////
CHWDeviceAudio::CHWDeviceAudio(CBGame* inGame):CHWDevice(inGame)
{
	m_NoSound = true;
}


//////////////////////////////////////////////////////////////////////////
CHWDeviceAudio::~CHWDeviceAudio()
{

}