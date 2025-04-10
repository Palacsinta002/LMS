import { useEffect, useRef } from 'react';
import { useLocation } from 'react-router-dom';

export default function usePreviousLocation() {
  const location = useLocation();
  const previousLocation = useRef(null);

  useEffect(() => {
    previousLocation.current = location;
  }, [location]);

  return previousLocation.current;
}