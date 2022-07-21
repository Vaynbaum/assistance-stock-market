# Assistance stock market

This is a course work on OOP 2021

The application allows you to `get` acquainted with general information about about `stock exchanges` and `assets`. 
The user can also `add` stock exchanges and assets to his "My Portfolio" if desired, in order to get `quotes of the asset` at any time.

***

# Domain model

The main objects are the `account`, `stock exchanges`, `assets`, `quotes`.

The `Account` object contains information about the user's username and password, as well as a list of stock exchanges added to My Portfolio for quick search.

The `Market` object contains general information of the stock exchange: country, abbreviation, unique identification number, time zone, 
as well as a list of assets added for quick search, which are traded on this stock exchange. 

The `Asset` object contains the general information of the asset: country, abbreviation, asset type, name of the investment instrument, 
the currency traded, as well as a number of quotes received in a specific time interval. 

The `Quote` object contains information of one asset quote: time stamp, opening price, closing price, maximum and minimum prices

<img width="700px" src="https://user-images.githubusercontent.com/78900834/180268119-78327083-09a8-484e-bb14-9d39c1526d37.png"> 

# About the app
The application allows
1. Authorization of users
2. Receiving data on stock exchanges, assets and quotes via the API of [the Twelve Data website](https://twelvedata.com/)
3. Filtering when adding
4. Saving this data to the database 
5. Visualization of the received quotes

# How To Use
By launching the application, the user can use its functionality `after authorization or registration`. 
To do this, he should go to the authorization form, select one of the operations and fill in the fields.
After that, if the values were entered correctly, a login will occur, otherwise, an error will be displayed.

<img width="485" alt="image" src="https://user-images.githubusercontent.com/78900834/180276083-31e558f5-4dbd-4363-b41b-5e8904743037.png">

To `get quotes`, the user needs to `select an stock exchange` from previously added stock exchanges, or add a new exchange, and then select it. 
After that, you need to choose from the added `assets`, or first add it and then `select`. After that, the user `sets the time interval` and `receives quotes`.

<img width="210" alt="image" src="https://user-images.githubusercontent.com/78900834/180276726-04a4a7cb-f792-4169-8db0-df8e66ea05f1.png">
<img width="380" alt="image" src="https://user-images.githubusercontent.com/78900834/180276800-37b50766-0658-4d71-897f-7d3f593c9aaf.png">
<img width="739" alt="image" src="https://user-images.githubusercontent.com/78900834/180276657-09d9fbc8-aada-4b20-9ca0-43631cce3aa2.png">

# Technologies in the project

The application is written using the platform .Net

The data is obtained via the API of [the Twelve Data website](https://twelvedata.com/)

The database is a local Microsoft SQL
