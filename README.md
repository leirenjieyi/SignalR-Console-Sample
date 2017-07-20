# SignalR-Console-Sample
SignalR for Conosle

例子执行过程中出现了http 500的错误，找到原因是MyHub类在声明时没有public关键字，导致访问限制。
例子执行过程中出现了http 400的错误，找到原因是http://localhost:5678和http://127.0.0.1:5678不能通用，这个还不知道为什么会这样。