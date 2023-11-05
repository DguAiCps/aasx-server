import requests
import base64

# Assuming 'aHR0cC4vL2k0MC5jdXN0b21lci5jb20vdHlwZS8xLzEvN0E3MTA0QkRBQjU3RTE4NA' is the Base64 encoded identifier for 'MaxTorque'
encoded_identifier = 'aHR0cC4vL2k0MC5jdXN0b21lci5jb20vdHlwZS8xLzEvN0E3MTA0QkRBQjU3RTE4NA'

# Add the necessary padding if it's missing
padding = '=' * (-len(encoded_identifier) % 4)
encoded_identifier += padding

# Decode the Base64 string
decoded_bytes = base64.urlsafe_b64decode(encoded_identifier.encode('utf-8'))

# Convert the bytes to a string
decoded_string = decoded_bytes.decode('utf-8')

print(decoded_string)

# The REST API endpoint URL for 'MaxTorque'
url = f'http://localhost:51710/submodels/{encoded_identifier}/submodel-elements/MaxTorque'

# Make the GET request
response = requests.get(url)

# Check if the request was successful
if response.status_code == 200:
    # Extract the JSON data from the response
    # data = response.json()
    print(response)
else:
    print(f"Error: Received status code {response.status_code}")
