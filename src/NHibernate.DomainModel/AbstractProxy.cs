using System;
using Iesi.Collections.Generic;

namespace NHibernate.DomainModel
{
	public interface AbstractProxy : FooProxy
	{
		ISet<object> Abstracts { get; set; }
		DateTime Time { get; set; }
	}
}