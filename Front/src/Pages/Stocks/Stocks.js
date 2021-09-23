import React from "react"
import Stock from "./Stock";
import "./Stocks.css"


class Stocks extends React.Component {
    render(){
        return (
            <div className="Stocks">
                    <Stock name="CDPR" count="5" price="172,5" fee="5" />
            </div>
        );
    }
}

export default Stocks;