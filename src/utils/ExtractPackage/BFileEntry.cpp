// BFileEntry.cpp: implementation of the CBFileEntry class.
//
//////////////////////////////////////////////////////////////////////

#include "stdafx.h"
#include "BFileEntry.h"

//////////////////////////////////////////////////////////////////////
// Construction/Destruction
//////////////////////////////////////////////////////////////////////


//////////////////////////////////////////////////////////////////////////
CBFileEntry::CBFileEntry()
{
	m_Length = m_CompressedLength = m_Offset = m_Flags = 0;
	m_Filename = "";

	m_JournalTime = 0;
}


//////////////////////////////////////////////////////////////////////////
CBFileEntry::~CBFileEntry()
{

}
