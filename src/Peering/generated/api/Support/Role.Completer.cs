// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Support
{

    /// <summary>The role of the contact.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.RoleTypeConverter))]
    public partial struct Role :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Noc".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Noc'", "Noc", global::System.Management.Automation.CompletionResultType.ParameterValue, "Noc");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Policy".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Policy'", "Policy", global::System.Management.Automation.CompletionResultType.ParameterValue, "Policy");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Technical".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Technical'", "Technical", global::System.Management.Automation.CompletionResultType.ParameterValue, "Technical");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Service".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Service'", "Service", global::System.Management.Automation.CompletionResultType.ParameterValue, "Service");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Escalation".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Escalation'", "Escalation", global::System.Management.Automation.CompletionResultType.ParameterValue, "Escalation");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Other".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Other'", "Other", global::System.Management.Automation.CompletionResultType.ParameterValue, "Other");
            }
        }
    }
}