import base64
import json
import requests

print("AAS Example Client V3")
print()

# Find full API at https://v3.admin-shell-io.com/swagger
# GET shells, which is with pagination
request_path = "http://localhost:5001/submodels/"

# Setup the session with proper credentials if not localhost
session = requests.Session()
if "localhost" not in request_path:
    session.auth = ('user', 'pass')  # Replace with actual credentials if needed

response = session.get(request_path)
json_data = response.json()

if 'result' in json_data:
    shells = json_data['result']
    for shell in shells:
        try:
            # Assuming shell is a dictionary with an 'idShort' key
            print(f"Received AAS: {shell['idShort']}")

            # Iterate through submodels if they exist
            if "OperationalData" == shell['idShort']:
                for smr in shell['submodelElements']:
                    print(smr)
                    if 'value' in smr.keys():
                        print(f"SubmodelElement: {smr['idShort']} : value { smr['value']}")
                    # Iterate through submodel elements here
                    # You would need to translate the AasCore specific deserialization
                    # and visiting logic into Python here

        except Exception as e:
            print(f"ERROR GET; {response.status_code}; {request_path}")
            if response.content:
                print(f"; {response.text}")
            print(e)

        print()
