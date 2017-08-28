
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<%@taglib prefix="sql" uri="http://java.sun.com/jsp/jstl/sql"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>New Administrator</title>
        <link rel="stylesheet" type="text/css" href="CSS/CSS.css">
    </head>
    
    <body>
        
        <div class = "hdr">
            <h1>Welcome new Administrator</h1>
            <h3>Please fill out the following information to join the Crimson Video team</h3>
        </div
        <div class = "frmRegDiv">
            <form action="AdminController" method="POST">
            <table border="0">
                <tbody>
                    <tr>
                        <td bgcolor="#cc0000"><font color="white">Profile Information</font></td>
                        <td bgcolor="#cc0000"></td>
                    </tr>
                    <tr>
                        <td>First name:</td>
                        <td><input type="text" name="first_name" value="" /></td>
                    </tr>
                    <tr>
                        <td>Last name:</td>
                        <td><input type="text" name="last_name" value="" /></td>
                    </tr>
                    <tr>
                        <td>Username:</td>
                        <td><input type="text" name="username" value="" /></td>
                    </tr>
                    <tr>
                        <td>Password:</td>
                        <td><input type="password" name="password" value="" /></td>
                    </tr>
                    <tr>
                        <td>Please re-enter password:</td>
                        <td><input type="password" name="password2" value="" /></td>
                    </tr>
                    <tr>
                        <td>ID picture:</td>
                        <td><input type="submit" value="Upload" name="uploadAdminPic" /></td>
                    </tr>
                    <tr>
                        <td bgcolor="#cc0000"><font color="white">Contact Information</font></td>
                        <td bgcolor="#cc0000"></td>
                    </tr>
                    <tr>
                        <td>Email:</td>
                        <td><input type="text" name="email" value="" /></td>
                    </tr>
                    <tr>
                        <td>Primary Phone #:</td>
                        <td><input type="text" name="phone" value="" /></td>
                    </tr>
                    <tr>
                        <td>Store ID number:</td>
                        <!--i want this to be a drop down box with the potential store ids, the customer shouldn't really know this-->
                        <td><select name="store_id">
                                <option>1</option>
                                <option>2</option>
                            </select></td>
                    </tr>
                    <tr>
                        <td bgcolor="#cc0000"><font color="white">Mailing Address</font></td>
                        <td bgcolor="#cc0000"></td>
                    </tr>
                    <tr>
                        <!--goes into the address table of the database-->
                        <td>Street Address:</td>
                        <td><input type="text" name="address" value="" /></td>
                    </tr>

                    <tr>
                        <!--goes into the address table of the database-->
                        <td>Address line 2, if needed:</td>
                        <td><input type="text" name="address2" value="" /></td>
                    </tr>
                    <tr>
                        <!--goes into the city table of the database-->
                        <td>City:</td>
                        <td><input type="text" name="city" value="" /></td>
                    </tr>
                    <tr>
                        <!--goes into the address table of the database-->
                        <td>Zip Code:</td>
                        <td><input type="text" name="postal_code" value="" /></td>
                    </tr>
                    <tr>
                        <!--goes into the address table of the database-->
                        <td>State:</td>
                        <td><input type="text" name="district" value="" /></td>
                    </tr>
                    <tr>
                        <!--goes into the country table of the database-->
                        <td>Country:</td>
                        <td><select name="countries" >
                                <option>Select Your Country</option>
                                <c:forEach items="${countries}" var="country">
                                    <option value="${country.country_id}"><c:out value="${country.country}"/></option>
                                </c:forEach>
                            </select>
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#cc0000"><font color="white">Information for us</font></td>
                        <td bgcolor="#cc0000"></td>
                    </tr>
                    <tr>
                        <td>Check box if active:</td>
                        <td><input type="checkbox" name="custCheckBox" value="ON" /></td>
                    </tr>
                    <tr>
                        <!--I would like to get the calendar implementation on this as well-->
                        <td>Today's date (YYYY-MM-DD):</td>
                        <td><input type="text" name="create_date" value="" /></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><input type="submit" value="Enter" name="adminRegister" /></td>
                    </tr>
                    <tr>
                        <td><input type="hidden" name="action" value="adminRegister"/></td></td>
                    </tr>
                </tbody>
            </table>
        </form>
    </body>
</html>