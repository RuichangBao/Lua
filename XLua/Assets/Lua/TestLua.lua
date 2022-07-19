function SafePack(...)
	local params = {...}
	params.n = select('#', ...)
    print(tostring(params))
	return params
end

function main()
    SafePack(1,2,3,4,5)
end

main()
