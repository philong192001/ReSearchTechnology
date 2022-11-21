using Core.Ids;
using Marten;
using Marten.Schema.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Marten.Ids
{
    public class MartenIdGenerator : IIdGenerator
    {
        private readonly IDocumentSession documentSession;

        public MartenIdGenerator(IDocumentSession documentSession)
        {
            this.documentSession = documentSession ?? throw new ArgumentNullException(nameof(documentSession));
        }

        public Guid New() => CombGuidIdGeneration.NewGuid();
    }
}
