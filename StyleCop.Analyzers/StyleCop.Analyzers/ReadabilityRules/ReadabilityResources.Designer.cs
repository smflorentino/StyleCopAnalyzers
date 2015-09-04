﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StyleCop.Analyzers.ReadabilityRules {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ReadabilityResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ReadabilityResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("StyleCop.Analyzers.ReadabilityRules.ReadabilityResources", typeof(ReadabilityResources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replace &apos;base.&apos; with &apos;this.&apos;.
        /// </summary>
        internal static string SA1100CodeFix {
            get {
                return ResourceManager.GetString("SA1100CodeFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A call to a member from an inherited class begins with &apos;base.&apos;, and the local class does not contain an override or implementation of the member..
        /// </summary>
        internal static string SA1100Description {
            get {
                return ResourceManager.GetString("SA1100Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not prefix calls with base unless local implementation exists.
        /// </summary>
        internal static string SA1100MessageFormat {
            get {
                return ResourceManager.GetString("SA1100MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not prefix calls with base unless local implementation exists.
        /// </summary>
        internal static string SA1100Title {
            get {
                return ResourceManager.GetString("SA1100Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prefix reference with &apos;this.&apos;.
        /// </summary>
        internal static string SA1101CodeFix {
            get {
                return ResourceManager.GetString("SA1101CodeFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A call to an instance member of the local class or a base class is not prefixed with &apos;this.&apos;, within a C# code file..
        /// </summary>
        internal static string SA1101Description {
            get {
                return ResourceManager.GetString("SA1101Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prefix local calls with this.
        /// </summary>
        internal static string SA1101MessageFormat {
            get {
                return ResourceManager.GetString("SA1101MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prefix local calls with this.
        /// </summary>
        internal static string SA1101Title {
            get {
                return ResourceManager.GetString("SA1101Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove separating lines.
        /// </summary>
        internal static string SA1102CodeFix {
            get {
                return ResourceManager.GetString("SA1102CodeFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A C# query clause does not begin on the same line as the previous clause, or on the next line..
        /// </summary>
        internal static string SA1102Description {
            get {
                return ResourceManager.GetString("SA1102Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query clause must follow previous clause..
        /// </summary>
        internal static string SA1102MessageFormat {
            get {
                return ResourceManager.GetString("SA1102MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query clause must follow previous clause.
        /// </summary>
        internal static string SA1102Title {
            get {
                return ResourceManager.GetString("SA1102Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Place on multiple lines.
        /// </summary>
        internal static string SA1103CodeFixMultipleLines {
            get {
                return ResourceManager.GetString("SA1103CodeFixMultipleLines", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Place on single line.
        /// </summary>
        internal static string SA1103CodeFixSingleLine {
            get {
                return ResourceManager.GetString("SA1103CodeFixSingleLine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The clauses within a C# query expression are not all placed on the same line, and each clause is not placed on its own line..
        /// </summary>
        internal static string SA1103Description {
            get {
                return ResourceManager.GetString("SA1103Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query clauses must be on separate lines or all on one line.
        /// </summary>
        internal static string SA1103MessageFormat {
            get {
                return ResourceManager.GetString("SA1103MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query clauses must be on separate lines or all on one line.
        /// </summary>
        internal static string SA1103Title {
            get {
                return ResourceManager.GetString("SA1103Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A clause within a C# query expression begins on the same line as the previous clause, when the previous clause spans across multiple lines..
        /// </summary>
        internal static string SA1104Description {
            get {
                return ResourceManager.GetString("SA1104Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query clause must begin on new line when previous clause spans multiple lines.
        /// </summary>
        internal static string SA1104MessageFormat {
            get {
                return ResourceManager.GetString("SA1104MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Insert new line.
        /// </summary>
        internal static string SA1104SA1105CodeFix {
            get {
                return ResourceManager.GetString("SA1104SA1105CodeFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query clause must begin on new line when previous clause spans multiple lines.
        /// </summary>
        internal static string SA1104Title {
            get {
                return ResourceManager.GetString("SA1104Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A clause within a C# query expression spans across multiple lines, and does not begin on its own line..
        /// </summary>
        internal static string SA1105Description {
            get {
                return ResourceManager.GetString("SA1105Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query clauses spanning multiple lines must begin on own line.
        /// </summary>
        internal static string SA1105MessageFormat {
            get {
                return ResourceManager.GetString("SA1105MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query clauses spanning multiple lines must begin on own line.
        /// </summary>
        internal static string SA1105Title {
            get {
                return ResourceManager.GetString("SA1105Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The C# code contains an extra semicolon..
        /// </summary>
        internal static string SA1106Description {
            get {
                return ResourceManager.GetString("SA1106Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Code must not contain empty statements.
        /// </summary>
        internal static string SA1106MessageFormat {
            get {
                return ResourceManager.GetString("SA1106MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Code must not contain empty statements.
        /// </summary>
        internal static string SA1106Title {
            get {
                return ResourceManager.GetString("SA1106Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter new line.
        /// </summary>
        internal static string SA1107CodeFix {
            get {
                return ResourceManager.GetString("SA1107CodeFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The C# code contains more than one statement on a single line..
        /// </summary>
        internal static string SA1107Description {
            get {
                return ResourceManager.GetString("SA1107Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Code must not contain multiple statements on one line.
        /// </summary>
        internal static string SA1107MessageFormat {
            get {
                return ResourceManager.GetString("SA1107MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Code must not contain multiple statements on one line.
        /// </summary>
        internal static string SA1107Title {
            get {
                return ResourceManager.GetString("SA1107Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A C# statement contains a comment between the declaration of the statement and the opening curly bracket of the statement..
        /// </summary>
        internal static string SA1108Description {
            get {
                return ResourceManager.GetString("SA1108Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Block statements must not contain embedded comments.
        /// </summary>
        internal static string SA1108MessageFormat {
            get {
                return ResourceManager.GetString("SA1108MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Block statements must not contain embedded comments.
        /// </summary>
        internal static string SA1108Title {
            get {
                return ResourceManager.GetString("SA1108Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A C# statement contains a region tag between the declaration of the statement and the opening curly bracket of the statement..
        /// </summary>
        internal static string SA1109Description {
            get {
                return ResourceManager.GetString("SA1109Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string SA1109MessageFormat {
            get {
                return ResourceManager.GetString("SA1109MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Block statements must not contain embedded regions.
        /// </summary>
        internal static string SA1109Title {
            get {
                return ResourceManager.GetString("SA1109Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The opening parenthesis or bracket is not placed on the same line as the method/indexer/attribute/array name..
        /// </summary>
        internal static string SA1110Description {
            get {
                return ResourceManager.GetString("SA1110Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Opening parenthesis or bracket must be on declaration line..
        /// </summary>
        internal static string SA1110MessageFormat {
            get {
                return ResourceManager.GetString("SA1110MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Opening parenthesis or bracket must be on declaration line.
        /// </summary>
        internal static string SA1110Title {
            get {
                return ResourceManager.GetString("SA1110Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The closing parenthesis or bracket in a call to or declaration of a C# method/indexer/attribute/array/constructor/delegate is not placed on the same line as the last parameter..
        /// </summary>
        internal static string SA1111Description {
            get {
                return ResourceManager.GetString("SA1111Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Closing parenthesis must be on line of last parameter.
        /// </summary>
        internal static string SA1111MessageFormat {
            get {
                return ResourceManager.GetString("SA1111MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Closing parenthesis must be on line of last parameter.
        /// </summary>
        internal static string SA1111Title {
            get {
                return ResourceManager.GetString("SA1111Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The closing parenthesis or bracket in a call to a C# method or indexer, or the declaration of a method or indexer, is not placed on the same line as the opening bracket when the element does not take any parameters..
        /// </summary>
        internal static string SA1112Description {
            get {
                return ResourceManager.GetString("SA1112Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Closing parenthesis must be on line of opening parenthesis.
        /// </summary>
        internal static string SA1112MessageFormat {
            get {
                return ResourceManager.GetString("SA1112MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Closing parenthesis must be on line of opening parenthesis.
        /// </summary>
        internal static string SA1112Title {
            get {
                return ResourceManager.GetString("SA1112Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A comma between two parameters in a call to a C# method or indexer, or in the declaration of a method or indexer, is not placed on the same line as the previous parameter..
        /// </summary>
        internal static string SA1113Description {
            get {
                return ResourceManager.GetString("SA1113Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Comma must be on the same line as previous parameter..
        /// </summary>
        internal static string SA1113MessageFormat {
            get {
                return ResourceManager.GetString("SA1113MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Comma must be on the same line as previous parameter.
        /// </summary>
        internal static string SA1113Title {
            get {
                return ResourceManager.GetString("SA1113Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The start of the parameter list for a method/constructor/indexer/array/operator call or declaration does not begin on the same line as the opening bracket, or on the line after the opening bracket..
        /// </summary>
        internal static string SA1114Description {
            get {
                return ResourceManager.GetString("SA1114Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter list must follow declaration.
        /// </summary>
        internal static string SA1114MessageFormat {
            get {
                return ResourceManager.GetString("SA1114MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter list must follow declaration.
        /// </summary>
        internal static string SA1114Title {
            get {
                return ResourceManager.GetString("SA1114Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A parameter within a C# method or indexer call or declaration does not begin on the same line as the previous parameter, or on the next line..
        /// </summary>
        internal static string SA1115Description {
            get {
                return ResourceManager.GetString("SA1115Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter must begin on the line after the previous parameter..
        /// </summary>
        internal static string SA1115MessageFormat {
            get {
                return ResourceManager.GetString("SA1115MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter must follow comma.
        /// </summary>
        internal static string SA1115Title {
            get {
                return ResourceManager.GetString("SA1115Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move first argument to next line.
        /// </summary>
        internal static string SA1116CodeFix {
            get {
                return ResourceManager.GetString("SA1116CodeFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameters to a C# method or indexer call or declaration span across multiple lines, but the first parameter does not start on the line after the opening bracket..
        /// </summary>
        internal static string SA1116Description {
            get {
                return ResourceManager.GetString("SA1116Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameters must begin on the line after the declaration, whenever the parameter span across multiple lines.
        /// </summary>
        internal static string SA1116MessageFormat {
            get {
                return ResourceManager.GetString("SA1116MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Split parameters must start on line after declaration.
        /// </summary>
        internal static string SA1116Title {
            get {
                return ResourceManager.GetString("SA1116Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameters to a C# method or indexer call or declaration are not all on the same line or each on a separate line..
        /// </summary>
        internal static string SA1117Description {
            get {
                return ResourceManager.GetString("SA1117Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string SA1117MessageFormat {
            get {
                return ResourceManager.GetString("SA1117MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameters must be on same line or separate lines.
        /// </summary>
        internal static string SA1117Title {
            get {
                return ResourceManager.GetString("SA1117Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A parameter to a C# method/indexer/attribute/array, other than the first parameter, spans across multiple lines. If the parameter is short, place the entire parameter on a single line. Otherwise, save the contents of the parameter in a temporary variable and pass the temporary variable as a parameter..
        /// </summary>
        internal static string SA1118Description {
            get {
                return ResourceManager.GetString("SA1118Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter spans multiple lines.
        /// </summary>
        internal static string SA1118MessageFormat {
            get {
                return ResourceManager.GetString("SA1118MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter must not span multiple lines.
        /// </summary>
        internal static string SA1118Title {
            get {
                return ResourceManager.GetString("SA1118Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove empty comment.
        /// </summary>
        internal static string SA1120CodeFix {
            get {
                return ResourceManager.GetString("SA1120CodeFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The C# comment does not contain any comment text..
        /// </summary>
        internal static string SA1120Description {
            get {
                return ResourceManager.GetString("SA1120Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Comments must contain text.
        /// </summary>
        internal static string SA1120MessageFormat {
            get {
                return ResourceManager.GetString("SA1120MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Comments must contain text.
        /// </summary>
        internal static string SA1120Title {
            get {
                return ResourceManager.GetString("SA1120Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replace with built-in type.
        /// </summary>
        internal static string SA1121CodeFix {
            get {
                return ResourceManager.GetString("SA1121CodeFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The code uses one of the basic C# types, but does not use the built-in alias for the type..
        /// </summary>
        internal static string SA1121Description {
            get {
                return ResourceManager.GetString("SA1121Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use built-in type alias.
        /// </summary>
        internal static string SA1121MessageFormat {
            get {
                return ResourceManager.GetString("SA1121MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use built-in type alias.
        /// </summary>
        internal static string SA1121Title {
            get {
                return ResourceManager.GetString("SA1121Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replace with string.Empty.
        /// </summary>
        internal static string SA1122CodeFix {
            get {
                return ResourceManager.GetString("SA1122CodeFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The C# code includes an empty string, written as &quot;&quot;..
        /// </summary>
        internal static string SA1122Description {
            get {
                return ResourceManager.GetString("SA1122Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use string.Empty for empty strings.
        /// </summary>
        internal static string SA1122MessageFormat {
            get {
                return ResourceManager.GetString("SA1122MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use string.Empty for empty strings.
        /// </summary>
        internal static string SA1122Title {
            get {
                return ResourceManager.GetString("SA1122Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The C# code contains a region within the body of a code element..
        /// </summary>
        internal static string SA1123Description {
            get {
                return ResourceManager.GetString("SA1123Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Region must not be located within a code element..
        /// </summary>
        internal static string SA1123MessageFormat {
            get {
                return ResourceManager.GetString("SA1123MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not place regions within elements.
        /// </summary>
        internal static string SA1123Title {
            get {
                return ResourceManager.GetString("SA1123Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The C# code contains a region..
        /// </summary>
        internal static string SA1124Description {
            get {
                return ResourceManager.GetString("SA1124Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not use regions.
        /// </summary>
        internal static string SA1124MessageFormat {
            get {
                return ResourceManager.GetString("SA1124MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not use regions.
        /// </summary>
        internal static string SA1124Title {
            get {
                return ResourceManager.GetString("SA1124Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Nullable&lt;T&gt; type has been defined not using the C# shorthand. For example, Nullable&lt;DateTime&gt; has been used instead of the preferred DateTime?.
        /// </summary>
        internal static string SA1125Description {
            get {
                return ResourceManager.GetString("SA1125Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use shorthand for nullable types.
        /// </summary>
        internal static string SA1125MessageFormat {
            get {
                return ResourceManager.GetString("SA1125MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use shorthand for nullable types.
        /// </summary>
        internal static string SA1125Title {
            get {
                return ResourceManager.GetString("SA1125Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A call to a member is not prefixed with the &apos;this.&apos;, &apos;base.&apos;, &apos;object.&apos; or &apos;typename.&apos; prefix to indicate the intended method call, within a C# code file..
        /// </summary>
        internal static string SA1126Description {
            get {
                return ResourceManager.GetString("SA1126Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string SA1126MessageFormat {
            get {
                return ResourceManager.GetString("SA1126MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prefix calls correctly.
        /// </summary>
        internal static string SA1126Title {
            get {
                return ResourceManager.GetString("SA1126Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Place each type constraint on a new line.
        /// </summary>
        internal static string SA1127CodeFix {
            get {
                return ResourceManager.GetString("SA1127CodeFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Each type constraint clause for a generic type parameter should be listed on a line of code by itself..
        /// </summary>
        internal static string SA1127Description {
            get {
                return ResourceManager.GetString("SA1127Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generic type constraints must be on their own line.
        /// </summary>
        internal static string SA1127MessageFormat {
            get {
                return ResourceManager.GetString("SA1127MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generic type constraints must be on their own line.
        /// </summary>
        internal static string SA1127Title {
            get {
                return ResourceManager.GetString("SA1127Title", resourceCulture);
            }
        }
    }
}
