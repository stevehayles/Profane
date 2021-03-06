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

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="ProfaneParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public interface IProfaneListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProfaneParser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompilationUnit([NotNull] ProfaneParser.CompilationUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProfaneParser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompilationUnit([NotNull] ProfaneParser.CompilationUnitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProfaneParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] ProfaneParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProfaneParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] ProfaneParser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProfaneParser.printstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrintstmt([NotNull] ProfaneParser.PrintstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProfaneParser.printstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrintstmt([NotNull] ProfaneParser.PrintstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProfaneParser.assignstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignstmt([NotNull] ProfaneParser.AssignstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProfaneParser.assignstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignstmt([NotNull] ProfaneParser.AssignstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProfaneParser.setstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSetstmt([NotNull] ProfaneParser.SetstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProfaneParser.setstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSetstmt([NotNull] ProfaneParser.SetstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProfaneParser.ifstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfstmt([NotNull] ProfaneParser.IfstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProfaneParser.ifstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfstmt([NotNull] ProfaneParser.IfstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProfaneParser.conditionExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConditionExpr([NotNull] ProfaneParser.ConditionExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProfaneParser.conditionExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConditionExpr([NotNull] ProfaneParser.ConditionExprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProfaneParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] ProfaneParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProfaneParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] ProfaneParser.ExprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProfaneParser.opExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpExpression([NotNull] ProfaneParser.OpExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProfaneParser.opExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpExpression([NotNull] ProfaneParser.OpExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProfaneParser.op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOp([NotNull] ProfaneParser.OpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProfaneParser.op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOp([NotNull] ProfaneParser.OpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProfaneParser.relop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelop([NotNull] ProfaneParser.RelopContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProfaneParser.relop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelop([NotNull] ProfaneParser.RelopContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProfaneParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTerm([NotNull] ProfaneParser.TermContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProfaneParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTerm([NotNull] ProfaneParser.TermContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProfaneParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumber([NotNull] ProfaneParser.NumberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProfaneParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumber([NotNull] ProfaneParser.NumberContext context);
}
