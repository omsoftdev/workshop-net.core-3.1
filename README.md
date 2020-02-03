# Available REST API endpoints:

# Get user by ID
GET /api/users/{id}

# Create User
POST /api/users
{
	"name": "name",
	"email": "email",
	"city":  "city",
	"country":  "country",	
	"postalcode":  "postalcode"
}

# Delete User
DELETE /api/users/{id}

# Get Workshop by ID
GET /api/workshops/{id}

# Create Workshop
POST /api/workshops
{
	"companyname": "companyname",
	"email": "email@email",
	"city": "city",
	"postalcode": "postalcode",
	"country": "country",
	"trademarks": ["BMW", "AUDI"]
}

# Find Workshop by ID
POST /api/workshops/search?city={cityName}

# Delete Workshop
DELETE /api/workshops/{id}

# Get Appointment by ID
GET /api/appointments/{id}

# Create Appointment
POST /api/appointments
{
	"UserId": "{UserId}",
	"WorkshopId": "{WorkshopId}",
	"Time": "2020-03-10",
	"CarTrademark": "BMW"
}

# Delete Appointment
DELETE /api/appointments/{id}

# Update Appointment
PUT /api/appointments
{
	"Id": "{AppointmentId}",
	"Time": "2020-03-31"
}
