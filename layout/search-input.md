
input[type="text"] {
    width: 130px;
    box-sizing: border-box;
    border: 1px solid black;
    border-radius: 4px;
    outline:none;
    padding: 12px 14px;
}

# css.
input[type="text"] {
    width: 130px;
    box-sizing: border-box;
    border: 1px solid black;
    border-radius: 4px;
    outline:none;
    padding: 12px 14px;
    
    //resize slowwwww
    transition:0.6s ease-in-out;
}

# focus to resize width.
input[type="text"]:focus{
    width:500px; 
    background-color:lightpink;
}