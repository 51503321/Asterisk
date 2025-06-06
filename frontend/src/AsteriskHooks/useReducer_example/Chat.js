import { _, debounce } from 'lodash';

export default function Chat({ contact, message, dispatch }) {
    return (
        <section className="chat">
            <textarea
                value={message}
                placeholder={'Chat to ' + contact.name}
                onChange={e => dispatch({ type: 'edited_message', contactId: contact.id, message: e.target.value })}
            />
            <br />
            <button
                onClick={() => {
                    alert(`Sending "${message}" to ${contact.email}`);
                    dispatch({
                        type: 'sent_message',
                    });
                }}
            >
                Send to {contact.email}
            </button>
        </section>
    );
}
