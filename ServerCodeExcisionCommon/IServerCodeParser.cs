using System.Collections.Generic;

namespace ServerCodeExcisionCommon
{
	public interface IServerCodeParser
	{
		Antlr4.Runtime.Tree.IParseTree GetParseTree();
	}
}