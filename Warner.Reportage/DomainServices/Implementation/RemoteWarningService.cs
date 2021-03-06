﻿using System;
using System.Collections.Generic;
using System.Linq;
using Warner.Api.Gateway;
using Warner.Domain;

namespace Warner.Reportage.DomainServices.Implementation
{
    public class RemoteWarningService : IWarningService
    {
        private readonly IWarnerReportingService webApi;

        public RemoteWarningService(IWarnerReportingService webApi)
        {
            this.webApi = webApi;
        }

        public List<BuildWarning> AllForBuild(long buildId)
        {
            return webApi.GetAllWarningsForBuild(buildId).ToList();
        }

        public List<BuildWarning> AllForBuildOfType(long buildId, string warningType)
        {
            return webApi.GetAllOfTypeForBuild(buildId, warningType);
        }

        public IDictionary<string, int> GetSummaryForBuild(long buildId)
        {
            return webApi.GetSummaryForBuild(buildId);
        }
    }
}
