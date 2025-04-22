import taskReducer from "./taskReducer";

let initialState = [];
let actions = [
  {
    type: "added",
    id: 1,
    text: "Visit Kafka Museum",
  },
  { type: "added", id: 2, text: "Watch a puppet show" },
  { type: "deleted", id: 1 },
  { type: "added", id: 3, text: "Lennon Wall pic" },
];

let finalState = actions.reduce(taskReducer, initialState);
const output = document.getElementById("output");
output.textContent = JSON.stringify(finalState, null, 2);

// const [tasks, setTasks] = useState(initialTasks); -> replace useState with useReducer below
const [tasks, dispatch] = useReducer(tasksReducer, initialTasks);
