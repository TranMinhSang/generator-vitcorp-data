using VitCorp.Model;
using VitCorp.Data.Abstract;

namespace VitCorp.Data.Repositories
{
    public class <%= name %>Repository : EntityBaseRepository<<%= name %>>, I<%= name %>Repository
    {
        public <%= name %>Repository(VitCorpContext context)
            : base(context)
        { }
   }
}
