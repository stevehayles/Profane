//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Profane.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class ProfaneLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, ID=3, SMILEY=4, WS=5, PLUS=6, EQUAL=7, ASSIGN=8, NOTEQUAL=9, 
		MINUS=10, OP=11, NUMBER=12, STRING=13;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "ID", "SMILEY", "WS", "PLUS", "EQUAL", "ASSIGN", "NOTEQUAL", 
		"MINUS", "OP", "INT", "NUMBER", "STRING"
	};


	public ProfaneLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public ProfaneLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'dump'", "'derp'", null, "':)'", null, "'+'", "'=='", "'='", "'!='", 
		"'-'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, "ID", "SMILEY", "WS", "PLUS", "EQUAL", "ASSIGN", "NOTEQUAL", 
		"MINUS", "OP", "NUMBER", "STRING"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Profane.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static ProfaneLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\xF', '\x62', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\a', '\x4', 
		',', '\n', '\x4', '\f', '\x4', '\xE', '\x4', '/', '\v', '\x4', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x6', '\x6', '\x35', 
		'\n', '\x6', '\r', '\x6', '\xE', '\x6', '\x36', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\v', 
		'\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x5', '\f', 'L', '\n', '\f', '\x3', '\r', '\x6', '\r', 'O', '\n', 
		'\r', '\r', '\r', '\xE', '\r', 'P', '\x3', '\xE', '\x3', '\xE', '\x3', 
		'\xE', '\x5', '\xE', 'V', '\n', '\xE', '\x5', '\xE', 'X', '\n', '\xE', 
		'\x3', '\xF', '\x3', '\xF', '\a', '\xF', '\\', '\n', '\xF', '\f', '\xF', 
		'\xE', '\xF', '_', '\v', '\xF', '\x3', '\xF', '\x3', '\xF', '\x2', '\x2', 
		'\x10', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', 
		'\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', 
		'\r', '\x19', '\x2', '\x1B', '\xE', '\x1D', '\xF', '\x3', '\x2', '\a', 
		'\x5', '\x2', '\x43', '\\', '\x61', '\x61', '\x63', '|', '\x6', '\x2', 
		'\x32', ';', '\x43', '\\', '\x61', '\x61', '\x63', '|', '\x5', '\x2', 
		'\v', '\f', '\xF', '\xF', '\"', '\"', '\x3', '\x2', '\x32', ';', '\x4', 
		'\x2', '\f', '\f', '$', '$', '\x2', 'j', '\x2', '\x3', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', 
		'\x3', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x5', '$', '\x3', '\x2', '\x2', 
		'\x2', '\a', ')', '\x3', '\x2', '\x2', '\x2', '\t', '\x30', '\x3', '\x2', 
		'\x2', '\x2', '\v', '\x34', '\x3', '\x2', '\x2', '\x2', '\r', ':', '\x3', 
		'\x2', '\x2', '\x2', '\xF', '<', '\x3', '\x2', '\x2', '\x2', '\x11', '?', 
		'\x3', '\x2', '\x2', '\x2', '\x13', '\x41', '\x3', '\x2', '\x2', '\x2', 
		'\x15', '\x44', '\x3', '\x2', '\x2', '\x2', '\x17', 'K', '\x3', '\x2', 
		'\x2', '\x2', '\x19', 'N', '\x3', '\x2', '\x2', '\x2', '\x1B', 'R', '\x3', 
		'\x2', '\x2', '\x2', '\x1D', 'Y', '\x3', '\x2', '\x2', '\x2', '\x1F', 
		' ', '\a', '\x66', '\x2', '\x2', ' ', '!', '\a', 'w', '\x2', '\x2', '!', 
		'\"', '\a', 'o', '\x2', '\x2', '\"', '#', '\a', 'r', '\x2', '\x2', '#', 
		'\x4', '\x3', '\x2', '\x2', '\x2', '$', '%', '\a', '\x66', '\x2', '\x2', 
		'%', '&', '\a', 'g', '\x2', '\x2', '&', '\'', '\a', 't', '\x2', '\x2', 
		'\'', '(', '\a', 'r', '\x2', '\x2', '(', '\x6', '\x3', '\x2', '\x2', '\x2', 
		')', '-', '\t', '\x2', '\x2', '\x2', '*', ',', '\t', '\x3', '\x2', '\x2', 
		'+', '*', '\x3', '\x2', '\x2', '\x2', ',', '/', '\x3', '\x2', '\x2', '\x2', 
		'-', '+', '\x3', '\x2', '\x2', '\x2', '-', '.', '\x3', '\x2', '\x2', '\x2', 
		'.', '\b', '\x3', '\x2', '\x2', '\x2', '/', '-', '\x3', '\x2', '\x2', 
		'\x2', '\x30', '\x31', '\a', '<', '\x2', '\x2', '\x31', '\x32', '\a', 
		'+', '\x2', '\x2', '\x32', '\n', '\x3', '\x2', '\x2', '\x2', '\x33', '\x35', 
		'\t', '\x4', '\x2', '\x2', '\x34', '\x33', '\x3', '\x2', '\x2', '\x2', 
		'\x35', '\x36', '\x3', '\x2', '\x2', '\x2', '\x36', '\x34', '\x3', '\x2', 
		'\x2', '\x2', '\x36', '\x37', '\x3', '\x2', '\x2', '\x2', '\x37', '\x38', 
		'\x3', '\x2', '\x2', '\x2', '\x38', '\x39', '\b', '\x6', '\x2', '\x2', 
		'\x39', '\f', '\x3', '\x2', '\x2', '\x2', ':', ';', '\a', '-', '\x2', 
		'\x2', ';', '\xE', '\x3', '\x2', '\x2', '\x2', '<', '=', '\a', '?', '\x2', 
		'\x2', '=', '>', '\a', '?', '\x2', '\x2', '>', '\x10', '\x3', '\x2', '\x2', 
		'\x2', '?', '@', '\a', '?', '\x2', '\x2', '@', '\x12', '\x3', '\x2', '\x2', 
		'\x2', '\x41', '\x42', '\a', '#', '\x2', '\x2', '\x42', '\x43', '\a', 
		'?', '\x2', '\x2', '\x43', '\x14', '\x3', '\x2', '\x2', '\x2', '\x44', 
		'\x45', '\a', '/', '\x2', '\x2', '\x45', '\x16', '\x3', '\x2', '\x2', 
		'\x2', '\x46', 'L', '\x5', '\r', '\a', '\x2', 'G', 'L', '\x5', '\xF', 
		'\b', '\x2', 'H', 'L', '\x5', '\x11', '\t', '\x2', 'I', 'L', '\x5', '\x13', 
		'\n', '\x2', 'J', 'L', '\x5', '\x15', '\v', '\x2', 'K', '\x46', '\x3', 
		'\x2', '\x2', '\x2', 'K', 'G', '\x3', '\x2', '\x2', '\x2', 'K', 'H', '\x3', 
		'\x2', '\x2', '\x2', 'K', 'I', '\x3', '\x2', '\x2', '\x2', 'K', 'J', '\x3', 
		'\x2', '\x2', '\x2', 'L', '\x18', '\x3', '\x2', '\x2', '\x2', 'M', 'O', 
		'\t', '\x5', '\x2', '\x2', 'N', 'M', '\x3', '\x2', '\x2', '\x2', 'O', 
		'P', '\x3', '\x2', '\x2', '\x2', 'P', 'N', '\x3', '\x2', '\x2', '\x2', 
		'P', 'Q', '\x3', '\x2', '\x2', '\x2', 'Q', '\x1A', '\x3', '\x2', '\x2', 
		'\x2', 'R', 'W', '\x5', '\x19', '\r', '\x2', 'S', 'U', '\a', '\x30', '\x2', 
		'\x2', 'T', 'V', '\x5', '\x19', '\r', '\x2', 'U', 'T', '\x3', '\x2', '\x2', 
		'\x2', 'U', 'V', '\x3', '\x2', '\x2', '\x2', 'V', 'X', '\x3', '\x2', '\x2', 
		'\x2', 'W', 'S', '\x3', '\x2', '\x2', '\x2', 'W', 'X', '\x3', '\x2', '\x2', 
		'\x2', 'X', '\x1C', '\x3', '\x2', '\x2', '\x2', 'Y', ']', '\a', '$', '\x2', 
		'\x2', 'Z', '\\', '\n', '\x6', '\x2', '\x2', '[', 'Z', '\x3', '\x2', '\x2', 
		'\x2', '\\', '_', '\x3', '\x2', '\x2', '\x2', ']', '[', '\x3', '\x2', 
		'\x2', '\x2', ']', '^', '\x3', '\x2', '\x2', '\x2', '^', '`', '\x3', '\x2', 
		'\x2', '\x2', '_', ']', '\x3', '\x2', '\x2', '\x2', '`', '\x61', '\a', 
		'$', '\x2', '\x2', '\x61', '\x1E', '\x3', '\x2', '\x2', '\x2', '\n', '\x2', 
		'-', '\x36', 'K', 'P', 'U', 'W', ']', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
