﻿using System.Threading.Tasks;

namespace TS.Common
{
    public interface IHandleEventPersist<in T>
        where T : Event
    {
        Task Persist(T persistEvent);
    }
}