import { useState } from "react";

type Status = "idle" | "loading" | "success" | "error";
const [status, setStatus] = useState<Status>("idle");

type RequestState =
  | { status: "idle" }
  | { status: "loading" }
  | { status: "success"; data: string }
  | { status: "error"; error: string };

const [requestState, setRequestState] = useState<RequestState>({
  status: "idle",
});
