interface MyButtonProps {
    title: string;
    disabled: boolean;
}

function MyButton({ title, disabled }: MyButtonProps) {
    return <button disabled={disabled}>{title}</button>;
}

const App = (props: any): JSX.Element => {
    return (
        <div>
            <h1>Welcome to my app</h1>
            <MyButton title="I'm a disabled button" disabled />
        </div>
    );
};

export default App;
