import base64
import json
import requests

url = 'http://localhost:5001/submodels/aHR0cDovL2k0MC5jdXN0b21lci5jb20vaW5zdGFuY2UvMS8xL0FDNjlCMUNCNDRGMDc5MzU/submodel-elements/RotationSpeed'

payload = {
    "modelType": "Property",
    'category': 'VARIABLE',
    'idShort': 'RotationSpeed',
    'valueType': 'xs:integer',
    'value': '11111'
}

# JSON으로 변환
headers = {'Content-Type': 'application/json'}

# PUT 요청 보내기
response = requests.put(url, headers=headers, data=json.dumps(payload))

# 결과 출력
# 결과 출력
print(response.status_code)
if response.status_code == 200:
    print("Value updated successfully.")
else:
    print(response.text)  # 오류 메시지 출력
