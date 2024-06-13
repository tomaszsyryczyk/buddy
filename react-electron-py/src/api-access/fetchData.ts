import axiosInstance from "./axios";

interface testDataParams{
  textToSend: string
}

const fetchData = {
  testData : async (params : testDataParams) => {
    const response = await axiosInstance.get("/get_val_from/", { params: {
        input: params.textToSend
      } });
    return response.data;
  }
}

export default fetchData;