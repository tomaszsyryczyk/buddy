import React from "react";
import PropTypes from 'prop-types';

class Stock extends React.Component{
    render(){
        const {name, count, price, fee} = this.props;
        return(
            <div className="Stock">
                <div className="Stock.Name">
                    {name}
                </div>
                <div className="Stock.Count">
                    {count}
                </div>
                <div className="Stock.Price">
                    {price}
                </div>
                <div className="Stock.Fee">
                    {fee}
                </div>
                <div className="Stock.Total">
                    {this.total(price,fee)}
                </div>
            </div>
        );
    }

    total(price, fee) {
        return price + fee;
    };
}

Stock.propTypes = {
    name: PropTypes.string, 
    count: PropTypes.number,
    price: PropTypes.number,
    fee: PropTypes.number
}



export default Stock;