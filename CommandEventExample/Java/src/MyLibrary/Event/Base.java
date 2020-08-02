package MyLibrary.Event;

import MyLibrary.IEvent;
import MyLibrary.IPayload;

import java.sql.Timestamp;

public abstract class Base<TPayload extends IPayload> implements IEvent<TPayload> {

    private final TPayload Payload;

    public Timestamp Occurred = new Timestamp(System.currentTimeMillis());

    public Base(TPayload payload) {
        this.Payload = payload;
    }

    public TPayload Payload() { return this.Payload; }
}
