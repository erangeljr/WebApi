using WebApi.Data.Entities;
using FluentNHibernate.Mapping;

namespace WebApi.Data.SqlServer.Mapping
{
    public abstract class VersionedClassMap<T> : ClassMap<T> where T : IVersionedEntity
    {
        protected VersionedClassMap()
        {
            Version(x => x.Version)
                .Column("ts")
                .CustomSqlType("RowVersion")
                .Generated.Always()
                .UnsavedValue("null");
        }
    }
}
