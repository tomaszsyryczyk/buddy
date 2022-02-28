﻿using System;
using System.Threading.Tasks;

namespace TS.Common
{
    public class EventMediator<TEvent> : IMediateEvents<TEvent>
    where TEvent : Event
    {
        private readonly IHandleEventPersist<TEvent> _eventPersister;
        private readonly IHandleEventProvide<TEvent> _eventProvider;
        private readonly IHandleEventExecution<TEvent> _eventExecutioner;
        private readonly IHandleEventValidation<TEvent> _eventValidation;

        public EventMediator(IHandleEventPersist<TEvent> eventPersister, 
            IHandleEventProvide<TEvent> eventProvider,
            IHandleEventExecution<TEvent> eventExecutioner,
            IHandleEventValidation<TEvent> eventValidation)
        {
            _eventValidation = eventValidation;
            _eventExecutioner = eventExecutioner;
            _eventProvider = eventProvider;
            _eventPersister = eventPersister;
        }

        public async Task Persist(TEvent persistEvent)
        {
            await _eventPersister.Persist(persistEvent);
        }

        public async Task<TEvent[]> GetAll()
        {
            return await _eventProvider.All();
        }

        public async Task Execute(TEvent toExecute)
        {
            await _eventExecutioner.Execute(toExecute);
        }

        public async Task Validate(TEvent toValidate)
        {
            await _eventValidation.Validate(toValidate);
        }
    }
}
