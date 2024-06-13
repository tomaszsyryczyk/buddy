import React, { MouseEvent , useState } from 'react';
import AppBar from './AppBar';
import axiosInstance from "./axios";

function App() {
  console.log("START");
  console.log(window.ipcRenderer);
    
  const [textToSend, setTextToSend] = useState<string>("test");
  const [serverResponse, setServerResponse] = useState<string | null>(null);

  const requestServer = async (event : MouseEvent<HTMLButtonElement>) => {
    event.preventDefault();
    const response = await axiosInstance.get("/get_val_from/", { params: {
        input: textToSend
      } });
    setServerResponse(response.data);
    
  };

  // useEffect(() => {
  //   console.log('Server response: ', serverResponse);
  //   // You can perform other actions here
  // }, [serverResponse]);
  
  
  return (
    <div className="flex flex-col h-screen">
      {window.Main && (
        <div className="flex-none">
          <AppBar />
        </div>
      )}
      <div className="flex-auto">
        <div className=" flex flex-col justify-center items-center h-full bg-gray-800 space-y-4">
          <h1 className="text-2xl text-gray-200">Vite + React + Typescript + Electron + Tailwind</h1>
          <button
            className="bg-yellow-400 py-2 px-4 rounded focus:outline-none shadow hover:bg-yellow-200"
            onClick={requestServer}
          >
            Click Me
          </button>
          <input value={textToSend} onChange={(event) => setTextToSend(event.target.value)}/>
          <h1 className="text-2xl text-gray-200">{ serverResponse }</h1>
        </div>
      </div>
    </div>
  );
}

export default App;
