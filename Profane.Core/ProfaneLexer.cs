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
		T__0=1, T__1=2, T__2=3, ID=4, SMILEY=5, WS=6, NUMBER=7, STRING=8;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "ID", "SMILEY", "WS", "INT", "NUMBER", "STRING"
	};


	public ProfaneLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public ProfaneLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'dump'", "'derp'", "'='", null, "':)'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, "ID", "SMILEY", "WS", "NUMBER", "STRING"
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
		'\x5964', '\x2', '\n', 'G', '\b', '\x1', '\x4', '\x2', '\t', '\x2', '\x4', 
		'\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', 
		'\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', 
		'\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', 
		'\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\a', '\x5', '$', '\n', '\x5', 
		'\f', '\x5', '\xE', '\x5', '\'', '\v', '\x5', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\a', '\x6', '\a', '-', '\n', '\a', '\r', '\a', '\xE', 
		'\a', '.', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x6', '\b', '\x34', 
		'\n', '\b', '\r', '\b', '\xE', '\b', '\x35', '\x3', '\t', '\x3', '\t', 
		'\x3', '\t', '\x5', '\t', ';', '\n', '\t', '\x5', '\t', '=', '\n', '\t', 
		'\x3', '\n', '\x3', '\n', '\a', '\n', '\x41', '\n', '\n', '\f', '\n', 
		'\xE', '\n', '\x44', '\v', '\n', '\x3', '\n', '\x3', '\n', '\x2', '\x2', 
		'\v', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', 
		'\r', '\b', '\xF', '\x2', '\x11', '\t', '\x13', '\n', '\x3', '\x2', '\a', 
		'\x5', '\x2', '\x43', '\\', '\x61', '\x61', '\x63', '|', '\x6', '\x2', 
		'\x32', ';', '\x43', '\\', '\x61', '\x61', '\x63', '|', '\x5', '\x2', 
		'\v', '\f', '\xF', '\xF', '\"', '\"', '\x3', '\x2', '\x32', ';', '\x4', 
		'\x2', '\f', '\f', '$', '$', '\x2', 'K', '\x2', '\x3', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\x11', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', '\x2', '\x2', 
		'\x3', '\x15', '\x3', '\x2', '\x2', '\x2', '\x5', '\x1A', '\x3', '\x2', 
		'\x2', '\x2', '\a', '\x1F', '\x3', '\x2', '\x2', '\x2', '\t', '!', '\x3', 
		'\x2', '\x2', '\x2', '\v', '(', '\x3', '\x2', '\x2', '\x2', '\r', ',', 
		'\x3', '\x2', '\x2', '\x2', '\xF', '\x33', '\x3', '\x2', '\x2', '\x2', 
		'\x11', '\x37', '\x3', '\x2', '\x2', '\x2', '\x13', '>', '\x3', '\x2', 
		'\x2', '\x2', '\x15', '\x16', '\a', '\x66', '\x2', '\x2', '\x16', '\x17', 
		'\a', 'w', '\x2', '\x2', '\x17', '\x18', '\a', 'o', '\x2', '\x2', '\x18', 
		'\x19', '\a', 'r', '\x2', '\x2', '\x19', '\x4', '\x3', '\x2', '\x2', '\x2', 
		'\x1A', '\x1B', '\a', '\x66', '\x2', '\x2', '\x1B', '\x1C', '\a', 'g', 
		'\x2', '\x2', '\x1C', '\x1D', '\a', 't', '\x2', '\x2', '\x1D', '\x1E', 
		'\a', 'r', '\x2', '\x2', '\x1E', '\x6', '\x3', '\x2', '\x2', '\x2', '\x1F', 
		' ', '\a', '?', '\x2', '\x2', ' ', '\b', '\x3', '\x2', '\x2', '\x2', '!', 
		'%', '\t', '\x2', '\x2', '\x2', '\"', '$', '\t', '\x3', '\x2', '\x2', 
		'#', '\"', '\x3', '\x2', '\x2', '\x2', '$', '\'', '\x3', '\x2', '\x2', 
		'\x2', '%', '#', '\x3', '\x2', '\x2', '\x2', '%', '&', '\x3', '\x2', '\x2', 
		'\x2', '&', '\n', '\x3', '\x2', '\x2', '\x2', '\'', '%', '\x3', '\x2', 
		'\x2', '\x2', '(', ')', '\a', '<', '\x2', '\x2', ')', '*', '\a', '+', 
		'\x2', '\x2', '*', '\f', '\x3', '\x2', '\x2', '\x2', '+', '-', '\t', '\x4', 
		'\x2', '\x2', ',', '+', '\x3', '\x2', '\x2', '\x2', '-', '.', '\x3', '\x2', 
		'\x2', '\x2', '.', ',', '\x3', '\x2', '\x2', '\x2', '.', '/', '\x3', '\x2', 
		'\x2', '\x2', '/', '\x30', '\x3', '\x2', '\x2', '\x2', '\x30', '\x31', 
		'\b', '\a', '\x2', '\x2', '\x31', '\xE', '\x3', '\x2', '\x2', '\x2', '\x32', 
		'\x34', '\t', '\x5', '\x2', '\x2', '\x33', '\x32', '\x3', '\x2', '\x2', 
		'\x2', '\x34', '\x35', '\x3', '\x2', '\x2', '\x2', '\x35', '\x33', '\x3', 
		'\x2', '\x2', '\x2', '\x35', '\x36', '\x3', '\x2', '\x2', '\x2', '\x36', 
		'\x10', '\x3', '\x2', '\x2', '\x2', '\x37', '<', '\x5', '\xF', '\b', '\x2', 
		'\x38', ':', '\a', '\x30', '\x2', '\x2', '\x39', ';', '\x5', '\xF', '\b', 
		'\x2', ':', '\x39', '\x3', '\x2', '\x2', '\x2', ':', ';', '\x3', '\x2', 
		'\x2', '\x2', ';', '=', '\x3', '\x2', '\x2', '\x2', '<', '\x38', '\x3', 
		'\x2', '\x2', '\x2', '<', '=', '\x3', '\x2', '\x2', '\x2', '=', '\x12', 
		'\x3', '\x2', '\x2', '\x2', '>', '\x42', '\a', '$', '\x2', '\x2', '?', 
		'\x41', '\n', '\x6', '\x2', '\x2', '@', '?', '\x3', '\x2', '\x2', '\x2', 
		'\x41', '\x44', '\x3', '\x2', '\x2', '\x2', '\x42', '@', '\x3', '\x2', 
		'\x2', '\x2', '\x42', '\x43', '\x3', '\x2', '\x2', '\x2', '\x43', '\x45', 
		'\x3', '\x2', '\x2', '\x2', '\x44', '\x42', '\x3', '\x2', '\x2', '\x2', 
		'\x45', '\x46', '\a', '$', '\x2', '\x2', '\x46', '\x14', '\x3', '\x2', 
		'\x2', '\x2', '\t', '\x2', '%', '.', '\x35', ':', '<', '\x42', '\x3', 
		'\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
