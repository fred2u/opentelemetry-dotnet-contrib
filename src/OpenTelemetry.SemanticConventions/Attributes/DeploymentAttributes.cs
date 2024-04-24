// Copyright The OpenTelemetry Authors
// SPDX-License-Identifier: Apache-2.0

// <auto-generated>This file has been auto generated from scripts/templates/SemanticConventionsAttributes.cs.j2</auto-generated>

#pragma warning disable CS1570 // XML comment has badly formed XML

using System;

namespace OpenTelemetry.SemanticConventions;

/// <summary>
/// Constants for semantic attribute names outlined by the OpenTelemetry specifications.
/// </summary>
public static class DeploymentAttributes
{
    /// <summary>
    /// Name of the <a href="https://wikipedia.org/wiki/Deployment_environment">deployment environment</a> (aka deployment tier).
    /// </summary>
    /// <remarks>
    /// <c>deployment.environment</c> does not affect the uniqueness constraints defined through
        /// the <c>service.namespace</c>, <c>service.name</c> and <c>service.instance.id</c> resource attributes.
        /// This implies that resources carrying the following attribute combinations MUST be
        /// considered to be identifying the same service:<ul>
        /// <li><c>service.name=frontend</c>, <c>deployment.environment=production</c></li>
        /// <li><c>service.name=frontend</c>, <c>deployment.environment=staging</c></li>
        /// </ul>.
    /// </remarks>
    public const string AttributeDeploymentEnvironment = "deployment.environment";
}