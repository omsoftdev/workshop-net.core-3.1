# Available REST API endpoints:

# Get user by ID
Get /api/users/{id}

# Create User
Post /api/users
{
	"name": "name",
	"email": "email",
	"city":  "city",
	"country":  "country",	
	"postalcode":  "postalcode"
}

# Delete User
Delete /api/users/{id}

# Get Workshop by ID
Get /api/workshops/{id}

# Create Workshop
Post /api/workshops
{
	"companyname": "companyname",
	"email": "email@email",
	"city": "city",
	"postalcode": "postalcode",
	"country": "country",
	"trademarks": ["BMW", "AUDI"]
}

# Find Workshop by cit
Post /api/workshops/search?city={cityName}

# Delete Workshop
Delete /api/workshops/{id}

# Get Appointment by ID
Get /api/appointments/{id}

# Create Appointment
Post /api/appointments
{
	"UserId": "{UserId}",
	"WorkshopId": "{WorkshopId}",
	"Time": "2020-03-10",
	"CarTrademark": "BMW"
}

# Delete Appointment
Delete /api/appointments/{id}

# Update Appointment
Put /api/appointments
{
	"Id": "{AppointmentId}",
	"Time": "2020-03-31"
}
