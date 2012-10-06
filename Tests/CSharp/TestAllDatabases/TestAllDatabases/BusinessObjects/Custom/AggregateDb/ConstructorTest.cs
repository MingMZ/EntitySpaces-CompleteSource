/*
===============================================================================
                    EntitySpaces 2010 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2010.1.0726.0
EntitySpaces Driver  : SQL
Date Generated       : 7/31/2010 9:20:58 PM
===============================================================================
*/

using System;

using EntitySpaces.Core;
using EntitySpaces.Interfaces;
using EntitySpaces.DynamicQuery;

namespace BusinessObjects
{
	public partial class ConstructorTest : esConstructorTest
	{
		public ConstructorTest()
		{
            this.DefaultDateTime = DateTime.Now;
            this.DefaultBool = false;
            this.DefaultInt = 0;
            this.DefaultString = "[new]";
		}
	}
}
