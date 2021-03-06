﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.PowerShell.Commands
{
    using System.Management.Automation;
    using Models.Authentication;
    using Models.Partners;
    using PartnerCenter.Models.Partners;

    [Cmdlet(VerbsCommon.Get, "PartnerMpnProfile")]
    [OutputType(typeof(PSMpnProfile))]
    public class GetPartnerMpnProfile : PartnerAsyncCmdlet
    {
        /// <summary>
        /// Gets or sets the MPN identifier.
        /// </summary>
        [Parameter(HelpMessage = "The partner's Microsoft Partner Network (MPN) identifier.", Mandatory = false)]
        [ValidateNotNull]
        public string MpnId { get; set; }

        /// <summary>
        /// Executes the operations associated with the cmdlet.
        /// </summary>
        public override void ExecuteCmdlet()
        {
            Scheduler.RunTask(async () =>
            {
                IPartner partner = await PartnerSession.Instance.ClientFactory.CreatePartnerOperationsAsync(CorrelationId, CancellationToken).ConfigureAwait(false);
                MpnProfile profile;

                if (string.IsNullOrEmpty(MpnId))
                {
                    profile = await partner.Profiles.MpnProfile.GetAsync(CancellationToken).ConfigureAwait(false);
                }
                else
                {
                    profile = await partner.Profiles.MpnProfile.GetAsync(MpnId, CancellationToken).ConfigureAwait(false);
                }

                WriteObject(new PSMpnProfile(profile));
            }, true);
        }
    }
}