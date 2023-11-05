import json
from opcua import Client
from opcua import ua

# OPC UA server endpoint
opc_server_url = "opc.tcp://localhost:51210/UA/SampleServer"

# Create an OPC UA client instance
client = Client(opc_server_url)


def node_to_dict(node):
    try:
        node_info = {
            "NodeId": str(node.nodeid),
            "BrowseName": str(node.get_browse_name()),
            "Description": str(node.get_description()),
            "Value": str(node.get_value())
        }
    except Exception as e:
        node_info = {
            "NodeId": str(node.nodeid),
            "error": str(e)
        }
    return node_info


def browse_nodes_to_json(node):
    node_info = node_to_dict(node)
    children = []
    for child_id in node.get_children():
        child = client.get_node(child_id)
        children.append(browse_nodes_to_json(child))
    if children:
        node_info['Children'] = children
    return node_info


try:
    # Connect to the server
    client.connect()

    root = client.get_root_node()
    print("root node: ", root)

    all_nodes_info = browse_nodes_to_json(root)

    # Serialize to a JSON formatted string
    json_data = json.dumps(all_nodes_info, indent=2)
    print(json_data)


except Exception as e:
    print(f"An error occurred: {e}")

finally:
    # Disconnect the client
    client.disconnect()
