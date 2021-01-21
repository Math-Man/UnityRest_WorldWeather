# Unity Rest Test Project (World Weather Thingy)
A test program I've written in unity in a couple hours to understand how REST and JSON works under Unity.

Uses https://openweathermap.org API to get the weather 
Cities are dotted on a spherical a very crusty equirectangular projection.
The list of cities is taken from here http://bulk.openweathermap.org/sample/ modified a little bit to fit json format.

The weather data is taken from the rest api and then stored in the model object.

The projection is really crusty the image I used is even crustier. I didn't even attempt to make it look good as I was just attempting to learn unity's Json utilities


API key is omitted, if you want to try this, put your key in the API_KEY constant in APIHandler.cs

In hindsight I should've used something with less vertices...

[![IMAGE ALT TEXT HERE](https://github.com/Math-Man/RESTUnity/blob/main/pg.gif)](https://github.com/Math-Man/RESTUnity/blob/main/pg.gif)

