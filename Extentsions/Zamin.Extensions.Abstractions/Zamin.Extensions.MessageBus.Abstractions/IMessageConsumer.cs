﻿namespace Zamin.Extentions.MessageBus.Abstractions;

public interface IMessageConsumer
{
    void ConsumeEvent(string sender, Parcel parcel);
    void ConsumeCommand(string sender, Parcel parcel);
}
